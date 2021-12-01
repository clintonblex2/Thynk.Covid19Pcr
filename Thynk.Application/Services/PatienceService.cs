using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thynk.Covid19Pcr.Application.DTOs.Response;
using Thynk.Covid19Pcr.Application.Interfaces.Repositories;
using Thynk.Covid19Pcr.Application.Interfaces.Service;
using Thynk.Covid19Pcr.Application.Interfaces.Shared;
using Thynk.Covid19Pcr.Application.Models.Request;
using Thynk.Covid19Pcr.Application.Models.Settings;
using Thynk.Covid19Pcr.Application.Models.ViewModels;
using Thynk.Covid19Pcr.Domain.Entities;
using Thynk.Covid19Pcr.Domain.Enums;
using Thynk.Covid19Pcr.Domain.Helpers;

namespace Thynk.Covid19Pcr.Application.Services
{
    public class PatienceService : IPatientService
    {
        private readonly IUnitOfWork _uow;
        private readonly ILogger<PatienceService> _logger;
        private readonly IMapper _mapper;
        private readonly IMailService _mailService;
        private readonly CovidSettings _settings;
        private readonly MailSettings _mailSettings;

        public PatienceService(IUnitOfWork uow, ILogger<PatienceService> logger, IMapper mapper, IMailService mailService, CovidSettings settings, MailSettings mailSettings)
        {
            _uow = uow;
            _logger = logger;
            _mapper = mapper;
            _settings = settings;
            _mailSettings = mailSettings;
            _mailService = mailService;
        }

        public async Task<ExecutedResult<string>> BookCovidPcrTest(BookingRequest request)
        {
            _logger.LogInformation("Thynk.Covid19Pcr: BookCovidPcrTest {@request}", request);

            if (!EnumHelper<Gender>.IsDefined(request.Gender))
                return ExecutedResult<string>.Failed("Invalid gender selected");

            var vaccineType = await _uow.Repository<VaccineTypes>().FindAsync(x => x.Id == request.VaccineTypeId);
            if (vaccineType == null)
                return ExecutedResult<string>.Failed("Vaccine type not found");

            if (!Utils.IsDateValid(request.DateOfBirth, 5))
                return ExecutedResult<string>.Failed("The minimum age for Covid-19 PCR Test is 5 years. Kindly check your date of birth.");

            int age = DateTime.Now.AddYears(-request.DateOfBirth.Year).Year;
            (bool, string) IsValid = VaccineTypes.IsValidAge(age, vaccineType.RecommendedAge);
            if (!IsValid.Item1)
                return ExecutedResult<string>.Failed(IsValid.Item2);

            var appointmentDay = await _uow.Repository<AvailableTestDays>().FirstOrDefaultInclude(
                x => x.Id == request.AppointmentDayId && x.OpenSlots > 0, i => i.TestLab, i => i.TestLab.TestLocation);

            if (appointmentDay == null)
                return ExecutedResult<string>.Failed("You can't book Covid-19 test appointment on the selected day");

            var patient = await _uow.Repository<Patients>().FindAsync(x => x.PhoneNumber == request.PhoneNumber || x.Email == request.Email);

            if (patient == null)
            {
                patient = _mapper.Map<Patients>(request);
                patient.Gender = EnumHelper<Gender>.Parse(request.Gender);
                patient.SetAge();
                _uow.Repository<Patients>().Add(patient);
            }

            (bool, string) createBooking = patient.CreateTestBooking(appointmentDay, vaccineType);
            _logger.LogInformation("Thynk.Covid19Pcr: BookedCovidPcrTest {@response}", createBooking);

            if (!createBooking.Item1)
                return ExecutedResult<string>.Failed(createBooking.Item2);

            if (_settings.SendMail && !Utils.IsNull(request.Email))
                await _mailService.SendAsync(new MailRequest
                {
                    From = _mailSettings.From,
                    To = request.Email,
                    Subject = "Covid-19 Test Booking",
                    Body = $"Dear {request.FirstName}, your " +
                    $"Covid-19 PCR test has been successfully booked. Your booking reference is {createBooking.Item2}.\nThank you."
                });

            await _uow.CommitAsync();

            // Send an Email/SMS notification to the patience
            return ExecutedResult<string>.Success($"Successfully booked Covid-19 PCR Test with Booking Reference. {createBooking.Item2}");
        }

        public async Task<ExecutedResult<TestBookings>> CancelBookedCovidPcrTest(CancelBookingRequest request)
        {
            var booking = await _uow.Repository<TestBookings>().FirstOrDefaultInclude(x => x.BookingReference == request.BookingReference && x.Patient.PhoneNumber == request.PhoneNumber, i => i.Patient, i => i.AvailableTestDay);
            if (booking == null)
                return ExecutedResult<TestBookings>.Failed("Covid-19 test booking not found");

            if (booking.BookingStatus == TestBookingStatus.Cancelled)
                return ExecutedResult<TestBookings>.Failed("Test booking already cancelled");

            if (booking.BookingStatus == TestBookingStatus.Confirmed)
                return ExecutedResult<TestBookings>.Failed("Test booking already completed");

            booking.BookingStatus = TestBookingStatus.Cancelled;
            booking.AvailableTestDay.OpenSlots++;

            await _uow.CommitAsync();

            if (_settings.SendMail && !Utils.IsNull(booking.Patient.Email))
                await _mailService.SendAsync(new MailRequest
                {
                    From = _mailSettings.From,
                    To = booking.Patient.Email,
                    Subject = "Covid-19 Test Cancellation",
                    Body = $"Dear {booking.Patient.FirstName}, your " +
                    $"Covid-19 PCR test has been cancelled.\nThank you."
                });

            return ExecutedResult<TestBookings>.Success(booking, "Test booking cancelled successfully");
        }

        public ExecutedResult<TestBookingVm> GetBookedCovidPcrTest(string bookingReference)
        {
            string sqlQuery = $"EXEC spGetPatienceBookedCovidTest '{bookingReference}'";
            var data = _uow.Repository<TestBookings>().SqlQuery<TestBookingVm>(sqlQuery).FirstOrDefault();

            if (data == null)
                return ExecutedResult<TestBookingVm>.Failed("The booking reference does not exist");

            return ExecutedResult<TestBookingVm>.Success(data, "Fetched booked Covid-19 PCR Test");
        }

        public ExecutedResult<TestResultVm> GetPatienceTestResult(PatienceTestResultRequest request)
        {
            string sqlQuery = $"EXEC spGetPatienceCovidTestResult '{request.BookingReference}', '{request.PhoneNumber}'";
            var data = _uow.Repository<TestBookings>().SqlQuery<TestResultVm>(sqlQuery).FirstOrDefault();
            if (data == null)
                return ExecutedResult<TestResultVm>.Failed();
            
            var status = EnumHelper<TestBookingStatus>.Parse(data.BookingStatus);

            if (status == TestBookingStatus.Cancelled)
                return ExecutedResult<TestResultVm>.Failed("This Covid-19 PCR test was cancelled");

            if (status == TestBookingStatus.Booked)
                return ExecutedResult<TestResultVm>.Failed("This Covid-19 PCR test is not yet ready");

            return ExecutedResult<TestResultVm>.Success(_mapper.Map<TestResultVm>(data), "Covid-19 PCR test result fetched");
        }

        public ExecutedResult<List<TestLocationVm>> GetLabLocations()
        {
            var labLocations = _uow.Repository<TestLocations>().FilterAsNoTracking(x => x.IsOperational, i => i.LabsInLocation);

            if (!labLocations.Any())
                return ExecutedResult<List<TestLocationVm>>.Failed();

            return ExecutedResult<List<TestLocationVm>>.Success(_mapper.Map<List<TestLocationVm>>(labLocations.ToList()));
        }

        public async Task<ExecutedResult<List<VaccineTypePatienceVm>>> GetVaccineTypes()
        {
            var approvedVaccineTypes = await _uow.Repository<VaccineTypes>().GetAllAsNoTracking(x => x.IsApproved);
            if (approvedVaccineTypes.Any())
                return ExecutedResult<List<VaccineTypePatienceVm>>.Success(approvedVaccineTypes.Select(x => VaccineTypePatienceVm.ToVaccineTypeDTOMap(x)).ToList(), "Successfully fetched approved vaccines");

            return ExecutedResult<List<VaccineTypePatienceVm>>.Failed();
        }

        public ExecutedResult<List<string>> GetGender()
        {
            var result = Enum.GetValues(typeof(Gender)).Cast<Gender>().Select(s => s.ToString()).ToList();
            _logger.LogInformation("Thynk.Covid19Pcr: Get Gender {@result}", result);
            return ExecutedResult<List<string>>.Success(result);
        }
    }
}
