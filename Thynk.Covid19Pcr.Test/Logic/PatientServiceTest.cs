using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Thynk.Covid19Pcr.Application.Interfaces.Repositories;
using Thynk.Covid19Pcr.Application.Interfaces.Service;
using Thynk.Covid19Pcr.Application.Interfaces.Shared;
using Thynk.Covid19Pcr.Application.Mappings;
using Thynk.Covid19Pcr.Application.Models.Settings;
using Thynk.Covid19Pcr.Application.Services;
using Thynk.Covid19Pcr.Domain.Entities;
using Thynk.Covid19Pcr.Domain.Enums;
using Thynk.Covid19Pcr.Test.Mock.PatientMock;
using Thynk.Covid19Pcr.Test.Mock.PatientMock.Request;
using Thynk.Covid19Pcr.Test.Mock.PatientMock.Response;
using Xunit;

namespace Thynk.Covid19Pcr.Test.Logic
{
    public class PatientServiceTest
    {
        private readonly CovidSettings _settings = new CovidSettings();
        private readonly MailSettings _mailSettings = new MailSettings();
        private readonly Mock<IUnitOfWork> _uow = new Mock<IUnitOfWork>();
        private readonly Mock<ILogger<PatienceService>> _logger = new Mock<ILogger<PatienceService>>();
        private readonly Mock<IMailService> _mailService = new Mock<IMailService>();
        private readonly IConfiguration configuration;
        private readonly IPatientService _patientService;
        private readonly IMapper mapper = null;

        public PatientServiceTest()
        {
            //auto mapper configuration
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            mapper = mockMapper.CreateMapper();

            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

            configuration.GetSection("MailSettings").Bind(_mailSettings);
            configuration.GetSection("CovidSettings").Bind(_settings);

            _patientService = new PatienceService(_uow.Object, _logger.Object, mapper, _mailService.Object, _settings, _mailSettings);
        }

        [Fact]
        public async Task BookCovidPcrTest_ShouldReturn_InvalidGender()
        {
            _uow.Setup(x => x.Repository<VaccineTypes>().FindAsync(It.IsAny<Expression<Func<VaccineTypes, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockInvalidGenderBookingResponse()));

            var er = await _patientService.BookCovidPcrTest(MockBookingRequest.MockInvalidGenderBookingRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.ProcessingError.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("Invalid gender selected", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task BookCovidPcrTest_ShouldReturn_VaccineTypeNotFound()
        {
            _uow.Setup(x => x.Repository<VaccineTypes>().FindAsync(It.IsAny<Expression<Func<VaccineTypes, bool>>>()));

            var er = await _patientService.BookCovidPcrTest(MockBookingRequest.MockValidGenderBookingRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.ProcessingError.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("Vaccine type not found", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task BookCovidPcrTest_ShouldReturn_InvalidAge()
        {
            _uow.Setup(x => x.Repository<VaccineTypes>().FindAsync(It.IsAny<Expression<Func<VaccineTypes, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockInvalidGenderBookingResponse()));

            var er = await _patientService.BookCovidPcrTest(MockBookingRequest.MockInValidAgeBookingRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.ProcessingError.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("The minimum age for Covid-19 PCR Test is 5 years. Kindly check your date of birth.", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task BookCovidPcrTest_ShouldReturn_RecommendedAge()
        {
            _uow.Setup(x => x.Repository<VaccineTypes>().FindAsync(It.IsAny<Expression<Func<VaccineTypes, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockModernaBookingResponse()));

            var er = await _patientService.BookCovidPcrTest(MockBookingRequest.MockRecommendedAgeBookingRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.ProcessingError.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("The recommended age for the selected vaccine is 18+", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task BookCovidPcrTest_ShouldReturn_NoAppointmentWhenSlotIsZero()
        {
            _uow.Setup(x => x.Repository<VaccineTypes>().FindAsync(It.IsAny<Expression<Func<VaccineTypes, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockPfizerBookingResponse()));

            _uow.Setup(x => x.Repository<AvailableTestDays>().FirstOrDefaultInclude(It.IsAny<Expression<Func<AvailableTestDays, bool>>>(), x => x.TestLab, x => x.TestLab.TestLocation));

            var er = await _patientService.BookCovidPcrTest(MockBookingRequest.MockValidGenderBookingRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.ProcessingError.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("You can't book Covid-19 test appointment on the selected day", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task BookCovidPcrTest_ShouldReturn_TestAlreadyScheduledOnSelectedDay()
        {
            _uow.Setup(x => x.Repository<VaccineTypes>().FindAsync(It.IsAny<Expression<Func<VaccineTypes, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockPfizerBookingResponse()));

            _uow.Setup(x => x.Repository<Patients>().FindAsync(It.IsAny<Expression<Func<Patients, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockPatientResponse()));

            _uow.Setup(x => x.Repository<AvailableTestDays>().FirstOrDefaultInclude(It.IsAny<Expression<Func<AvailableTestDays, bool>>>(), x => x.TestLab, x => x.TestLab.TestLocation))
                .Returns(Task.FromResult(MockBookingResponse.MockAvailableTestDayWithSlotsResponse()));

            var er = await _patientService.BookCovidPcrTest(MockBookingRequest.MockValidGenderBookingRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.ProcessingError.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("You've already scheduled a Covid-19 test appointment on the selected day", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task BookCovidPcrTest_ShouldReturn_NoAvailableSlotForSelectedDay()
        {
            _uow.Setup(x => x.Repository<VaccineTypes>().FindAsync(It.IsAny<Expression<Func<VaccineTypes, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockPfizerBookingResponse()));

            _uow.Setup(x => x.Repository<Patients>().FindAsync(It.IsAny<Expression<Func<Patients, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockPatient2Response()));

            _uow.Setup(x => x.Repository<AvailableTestDays>().FirstOrDefaultInclude(It.IsAny<Expression<Func<AvailableTestDays, bool>>>(), x => x.TestLab, x => x.TestLab.TestLocation))
                .Returns(Task.FromResult(MockBookingResponse.MockAvailableTestDayWithZeroSlotResponse()));

            var er = await _patientService.BookCovidPcrTest(MockBookingRequest.MockValidGenderBookingRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.ProcessingError.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("No available slot for the selected day", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task BookCovidPcrTest_ShouldReturn_InactiveLabForSelectedDay()
        {
            _uow.Setup(x => x.Repository<VaccineTypes>().FindAsync(It.IsAny<Expression<Func<VaccineTypes, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockPfizerBookingResponse()));

            _uow.Setup(x => x.Repository<Patients>().FindAsync(It.IsAny<Expression<Func<Patients, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockPatient2Response()));

            _uow.Setup(x => x.Repository<AvailableTestDays>().FirstOrDefaultInclude(It.IsAny<Expression<Func<AvailableTestDays, bool>>>(), x => x.TestLab, x => x.TestLab.TestLocation))
                .Returns(Task.FromResult(MockBookingResponse.MockAvailableTestDayWithInactiveLabResponse()));

            var er = await _patientService.BookCovidPcrTest(MockBookingRequest.MockValidGenderBookingRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.ProcessingError.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("The allocated test lab for the selected day is currently unavailable", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task BookCovidPcrTest_ShouldReturn_ScheduleTestForFutureDate()
        {
            _uow.Setup(x => x.Repository<VaccineTypes>().FindAsync(It.IsAny<Expression<Func<VaccineTypes, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockPfizerBookingResponse()));

            _uow.Setup(x => x.Repository<Patients>().FindAsync(It.IsAny<Expression<Func<Patients, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockPatient2Response()));

            _uow.Setup(x => x.Repository<AvailableTestDays>().FirstOrDefaultInclude(It.IsAny<Expression<Func<AvailableTestDays, bool>>>(), x => x.TestLab, x => x.TestLab.TestLocation))
                .Returns(Task.FromResult(MockBookingResponse.MockAvailableTestDayWithPastDateResponse()));

            var er = await _patientService.BookCovidPcrTest(MockBookingRequest.MockValidGenderBookingRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.ProcessingError.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("You cannot book a test appointment in the past. Kindly enter a future date", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task BookCovidPcrTest_ShouldReturn_TestBookingSuccessful()
        {
            _uow.Setup(x => x.Repository<VaccineTypes>().FindAsync(It.IsAny<Expression<Func<VaccineTypes, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockPfizerBookingResponse()));

            _uow.Setup(x => x.Repository<Patients>().FindAsync(It.IsAny<Expression<Func<Patients, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockPatient2Response()));

            _uow.Setup(x => x.Repository<AvailableTestDays>().FirstOrDefaultInclude(It.IsAny<Expression<Func<AvailableTestDays, bool>>>(), x => x.TestLab, x => x.TestLab.TestLocation))
                .Returns(Task.FromResult(MockBookingResponse.MockAvailableTestDayWithValidResponse()));

            var er = await _patientService.BookCovidPcrTest(MockBookingRequest.MockValidGenderBookingRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.Success.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task CancelBookedCovidPcrTest_ShouldReturn_TestBookingNotFound()
        {
            _uow.Setup(x => x.Repository<TestBookings>().FirstOrDefaultInclude(It.IsAny<Expression<Func<TestBookings, bool>>>(), x => x.Patient, x => x.AvailableTestDay));
                
            var er = await _patientService.CancelBookedCovidPcrTest(MockCancelBookedRequest.MockValidCancelRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.ProcessingError.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("Covid-19 test booking not found", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task CancelBookedCovidPcrTest_ShouldReturn_TestAlreadyCancelled()
        {
            _uow.Setup(x => x.Repository<TestBookings>().FirstOrDefaultInclude(It.IsAny<Expression<Func<TestBookings, bool>>>(), x => x.Patient, x => x.AvailableTestDay))
                .Returns(Task.FromResult(MockBookingResponse.MockCancelledTestBookingsResponse()));

            var er = await _patientService.CancelBookedCovidPcrTest(MockCancelBookedRequest.MockValidCancelRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.ProcessingError.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("Test booking already cancelled", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task CancelBookedCovidPcrTest_ShouldReturn_TestAlreadyConfirmed()
        {
            _uow.Setup(x => x.Repository<TestBookings>().FirstOrDefaultInclude(It.IsAny<Expression<Func<TestBookings, bool>>>(), x => x.Patient, x => x.AvailableTestDay))
                .Returns(Task.FromResult(MockBookingResponse.MockConfirmedTestBookingsResponse()));

            var er = await _patientService.CancelBookedCovidPcrTest(MockCancelBookedRequest.MockValidCancelRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.ProcessingError.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("Test booking already completed", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task CancelBookedCovidPcrTest_ShouldReturn_BookingCancelled()
        {
            _uow.Setup(x => x.Repository<TestBookings>().FirstOrDefaultInclude(It.IsAny<Expression<Func<TestBookings, bool>>>(), x => x.Patient, x => x.AvailableTestDay))
                .Returns(Task.FromResult(MockBookingResponse.MockBookedTestBookingsResponse()));

            var er = await _patientService.CancelBookedCovidPcrTest(MockCancelBookedRequest.MockValidCancelRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.Success.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.NotNull(er.Result);
            Assert.Equal("Test booking cancelled successfully", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public void GetLabLocations_ShouldReturn_AvailableLabLocations()
        {
            _uow.Setup(x => x.Repository<TestLocations>().FilterAsNoTracking(It.IsAny<Expression<Func<TestLocations, bool>>>(), x => x.LabsInLocation))
                .Returns(MockBookingResponse.MockEnumerableTestLocationResponse().AsQueryable());

            var er = _patientService.GetLabLocations();

            Assert.NotNull(er);
            Assert.True(ResponseCode.Success.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.True(1.Equals(er.Result.Count));
            Assert.Equal("Request was successful", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task GetLabLocations_ShouldReturn_VaacineTypes()
        {
            _uow.Setup(x => x.Repository<VaccineTypes>().GetAllAsNoTracking(It.IsAny<Expression<Func<VaccineTypes, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockVaccineTypes().AsEnumerable()));

            var er = await _patientService.GetVaccineTypes();

            Assert.NotNull(er);
            Assert.True(ResponseCode.Success.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.True(2.Equals(er.Result.Count));
            Assert.Equal("Successfully fetched approved vaccines", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }
    }
}
