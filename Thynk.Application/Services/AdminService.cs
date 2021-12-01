using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
using Thynk.Covid19Pcr.Application.Validation;
using Thynk.Covid19Pcr.Domain.Entities;
using Thynk.Covid19Pcr.Domain.Helpers;

namespace Thynk.Covid19Pcr.Application.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork _uow;
        private readonly ILogger<AdminService> _logger;
        private readonly IMapper _mapper;
        private readonly IMailService _mailService;
        private readonly CovidSettings _settings;
        private readonly MailSettings _mailSettings;

        public AdminService(IUnitOfWork uow, ILogger<AdminService> logger, IMapper mapper, CovidSettings settings, IMailService mailService, MailSettings mailSettings)
        {
            _uow = uow;
            _logger = logger;
            _mapper = mapper;
            _settings = settings;
            _mailService = mailService;
            _mailSettings = mailSettings;
        }

        public async Task<ExecutedResult<string>> AddVaccineType(AddVaccineTypeRequest request)
        {
            _logger.LogInformation("Thynk.Covid19: AddVaccineType {@request}", request);
            
            var vaccineType = _mapper.Map<VaccineTypes>(request);
            _uow.Repository<VaccineTypes>().Add(vaccineType);
            await _uow.CommitAsync();
            return ExecutedResult<string>.Success("Added new vaccine type");
        }

        public async Task<ExecutedResult<int>> AllocateMoreSpace(AllocateMoreSpaceRequest request)
        {
            _logger.LogInformation("Thynk.Covid19: AllocateMoreSpace {@request}", request);
            var availableTestDay = await _uow.Repository<AvailableTestDays>().FindAsync(x => x.Id == request.AvailableSpaceId);
            if (availableTestDay == null)
                return ExecutedResult<int>.Failed();

            availableTestDay.OpenSlots += request.NewSlot;
            await _uow.CommitAsync();
            return ExecutedResult<int>.Success(availableTestDay.OpenSlots, "Added new slot(s)");
        }

        public async Task<ExecutedResult<string>> AssignSlotToTestLab(AssignSlotRequest request)
        {
            _logger.LogInformation("Thynk.Covid19: AssignSlotToTestLab {@request}", request);
            var testLab = await _uow.Repository<TestLabs>().FirstOrDefaultInclude(x => x.Id == request.TestLabId, i => i.TestLocation, i => i.AvailableDays);
            if (testLab == null)
                return ExecutedResult<string>.Failed("Test lab not found");

            if (request.SelectedDate.Date < DateTime.Now.Date)
                return ExecutedResult<string>.Failed("The selected date must be a future date");

            if (testLab.AvailableDays.Any(x => x.AvailableDate.Date == request.SelectedDate.Date))
                return ExecutedResult<string>.Failed("The selected date has already been alloted to this test lab.");

            _uow.Repository<AvailableTestDays>().Add(new AvailableTestDays { AvailableDate = request.SelectedDate, OpenSlots = request.Slot, TestLabId = testLab.Id });
            
            await _uow.CommitAsync();
            return ExecutedResult<string>.Success("Assigned slot to test lab");
        }

        public async Task<ExecutedResult<TestBookingVm>> CompleteBookedTest(CompleteBookedTestRequest request)
        {
            _logger.LogInformation("Thynk.Covid19: CompleteBookedTest {@request}", request);
            var testBooking = await _uow.Repository<TestBookings>().FirstOrDefaultInclude(x => x.BookingReference == request.BookingReference, i => i.Patient,
                i => i.VaccineType, i => i.AvailableTestDay, i => i.AvailableTestDay.TestLab, i => i.AvailableTestDay.TestLab.TestLocation);

            if (testBooking == null)
                return ExecutedResult<TestBookingVm>.Failed("Covid-19 Test booking not found");

            (bool, string) result = testBooking.AddPatienceLabTestResult(request.TestResultType);
            if (!result.Item1)
                return ExecutedResult<TestBookingVm>.Failed(result.Item2);


            await _uow.CommitAsync();

            if (_settings.SendMail && !Utils.IsNull(testBooking.Patient.Email))
                await _mailService.SendAsync(new MailRequest
                {
                    From = _mailSettings.From,
                    To = testBooking.Patient.Email,
                    Subject = "Booking Confirmation",
                    Body = $"Dear {testBooking.Patient.FirstName}, your " +
                    "Covid-19 PCR test has been confirmed. Your result will be available within 12 - 24 hours.\nThank you."
                });

            return ExecutedResult<TestBookingVm>.Success(_mapper.Map<TestBookingVm>(testBooking), "Covid-19 test result added");
        }

        public ExecutedResult<List<VaccineTypesVm>> FetchVaccineTypes()
        {
            var vaccineTypes = _uow.Repository<VaccineTypes>().GetAll();
            if (!vaccineTypes.Any())
                return ExecutedResult<List<VaccineTypesVm>>.Failed("No available Covid-19 vaccine type");

            return ExecutedResult<List<VaccineTypesVm>>.Success(_mapper.Map<List<VaccineTypesVm>>(vaccineTypes.ToList()));
        }

        public ExecutedResult<PaginatedResponse> GetBookedCovidPcrTest(PaginatedRequest request)
        {
            if (!Validate.ValidateRequest(request))
                return ExecutedResult<PaginatedResponse>.Failed("Start date cannot be higher than end date");

            string sqlQuery = $"EXEC spGetBookedCovidTest '{request.From:yyyy-MM-dd HH:mm:ss.fff}', '{request.To:yyyy-MM-dd HH:mm:ss.fff}', '{request.Page}', '{request.PageSize}'";
            var data = _uow.Repository<TestBookings>().SqlQuery<TestBookingVm>(sqlQuery).ToList();
            if (!data.Any())
                return ExecutedResult<PaginatedResponse>.Failed();

            int totalCount = data.Count;

            var response = new PaginatedResponse
            {
                CurrentPage = request.Page,
                TotalCount = totalCount,
                TotalPages = (int)Math.Ceiling((decimal)totalCount / request.PageSize),
                Data = data
            };

            return ExecutedResult<PaginatedResponse>.Success(response, "Fetched booked Covid-19 PCR Test(s)");
        }

        public ExecutedResult<PaginatedResponse> GetCovidPcrTestResult(CovidTestResultRequest request)
        {
            if (!Validate.ValidateRequest(request))
                return ExecutedResult<PaginatedResponse>.Failed("Start date cannot be higher than end date");

            string sqlQuery = $"EXEC spGetCovidTestResult '{request.From:yyyy-MM-dd HH:mm:ss.fff}', '{request.To:yyyy-MM-dd HH:mm:ss.fff}', '{request.Page}', '{request.PageSize}'";

            var data = _uow.Repository<TestBookings>().SqlQuery<TestResultVm>(sqlQuery).ToList();
            if (!data.Any())
                return ExecutedResult<PaginatedResponse>.Failed();

            int totalCount = data.Count;

            var response = new PaginatedResponse
            {
                CurrentPage = request.Page,
                TotalCount = totalCount,
                TotalPages = (int)Math.Ceiling((decimal)totalCount / request.PageSize),
                Data = data
            };

            return ExecutedResult<PaginatedResponse>.Success(response, "Fetched booked Covid-19 PCR Test");
        }

        public ExecutedResult<PaginatedResponse> GetAvailableTestDays(TestDaysWithLabLocationRequest request)
        {
            string sqlQuery = $"EXEC spGetAvailableTestDays '{request.Page}', '{request.PageSize}'";
            var data = _uow.Repository<AvailableTestDays>().SqlQuery<TestDaysWithLabLocationVm>(sqlQuery).ToList();
            if (!data.Any())
                return ExecutedResult<PaginatedResponse>.Failed();

            int totalCount = data.Count;

            var response = new PaginatedResponse
            {
                CurrentPage = request.Page,
                TotalCount = totalCount,
                TotalPages = (int)Math.Ceiling((decimal)totalCount / request.PageSize),
                Data = data
            };

            return ExecutedResult<PaginatedResponse>.Success(response, "Fetched available test days with Labs and Locations");
        }

        public ExecutedResult<List<LocationsWithLabsVm>> GetLocationsWithTestLabs()
        {
            var locations = _uow.Repository<TestLocations>().FilterAsNoTracking(null, null).
                Include(x => x.LabsInLocation).ThenInclude(a => a.AvailableDays);
            if (!locations.Any())
                return ExecutedResult<List<LocationsWithLabsVm>>.Failed();

            return ExecutedResult<List<LocationsWithLabsVm>>.Success(_mapper.Map<List<LocationsWithLabsVm>>(locations.ToList()));
        }

        public async Task<ExecutedResult<TestDaysWithLabLocationVm>> GetAvailableTestDay(long id)
        {
            var availableTestDay = await _uow.Repository<AvailableTestDays>()
                 .FirstOrDefaultInclude(x => x.Id == id, x => x.TestLab, x => x.TestLab.TestLocation);
            if (availableTestDay == null)
                return ExecutedResult<TestDaysWithLabLocationVm>.Failed("Covid-19 Test available day not found");

            return ExecutedResult<TestDaysWithLabLocationVm>.Success(_mapper.Map<TestDaysWithLabLocationVm>(availableTestDay));
        }
    }
}
