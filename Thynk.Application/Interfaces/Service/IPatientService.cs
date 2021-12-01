using System.Collections.Generic;
using System.Threading.Tasks;
using Thynk.Covid19Pcr.Application.DTOs.Response;
using Thynk.Covid19Pcr.Application.Models.Request;
using Thynk.Covid19Pcr.Application.Models.ViewModels;
using Thynk.Covid19Pcr.Domain.Entities;

namespace Thynk.Covid19Pcr.Application.Interfaces.Service
{
    public interface IPatientService
    {
        ExecutedResult<List<string>> GetGender();
        Task<ExecutedResult<string>> BookCovidPcrTest(BookingRequest request);
        Task<ExecutedResult<TestBookings>> CancelBookedCovidPcrTest(CancelBookingRequest request);
        Task<ExecutedResult<List<VaccineTypePatienceVm>>> GetVaccineTypes();
        ExecutedResult<TestResultVm> GetPatienceTestResult(PatienceTestResultRequest request);
        ExecutedResult<List<TestLocationVm>> GetLabLocations();
        ExecutedResult<TestBookingVm> GetBookedCovidPcrTest(string bookingReference);
    }
}
