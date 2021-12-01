using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.IO;
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
using Thynk.Covid19Pcr.Test.Mock.PatientMock.Request;
using Thynk.Covid19Pcr.Test.Mock.PatientMock.Response;
using Xunit;

namespace Thynk.Covid19Pcr.Test.Logic
{
    public class AdminServiceTest
    {
        private readonly CovidSettings _settings = new();
        private readonly MailSettings _mailSettings = new();
        private readonly Mock<IUnitOfWork> _uow = new();
        private readonly Mock<ILogger<AdminService>> _logger = new();
        private readonly Mock<IMailService> _mailService = new();
        private readonly IConfiguration configuration;
        private readonly IAdminService _adminService;
        private readonly IMapper mapper = null;

        public AdminServiceTest()
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

            _adminService = new AdminService(_uow.Object, _logger.Object, mapper, _settings, _mailService.Object, _mailSettings);
        }

        [Fact]
        public async Task CancelBookedCovidPcrTest_ShouldReturn_TestAlreadyConfirmed()
        {
            _uow.Setup(x => x.Repository<VaccineTypes>().Add(It.IsAny<VaccineTypes>()))
                .Returns(MockBookingResponse.MockModernaBookingResponse());

            var er = await _adminService.AddVaccineType(MockRequests.MockAddVaccineTypeRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.Success.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("Added new vaccine type", er.Result);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task AllocateMoreSpace_ShouldReturn_AddNewSlot()
        {
            _uow.Setup(x => x.Repository<AvailableTestDays>().FindAsync(It.IsAny<Expression<Func<AvailableTestDays, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockAvailableTestDayWithZeroSlotResponse()));

            var er = await _adminService.AllocateMoreSpace(MockRequests.MockAllocateMoreSpaceRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.Success.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("Added new slot(s)", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }

        [Fact]
        public async Task AssignSlotToTestLab_ShouldReturn_AddNewSlot()
        {
            _uow.Setup(x => x.Repository<TestLabs>().FirstOrDefaultInclude(It.IsAny<Expression<Func<TestLabs, bool>>>()))
                .Returns(Task.FromResult(MockBookingResponse.MockTestLabsResponse()));

            var er = await _adminService.AssignSlotToTestLab(MockRequests.MockAssignSlotRequest());

            Assert.NotNull(er);
            Assert.True(ResponseCode.ProcessingError.Equals(er.Response));
            Assert.NotNull(er.Message);
            Assert.Equal("Test lab not found", er.Message);
            Assert.True(0.Equals(er.ValidationMessages.Count));
        }
    }
}
