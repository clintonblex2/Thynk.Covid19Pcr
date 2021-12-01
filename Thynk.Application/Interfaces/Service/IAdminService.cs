using System.Collections.Generic;
using System.Threading.Tasks;
using Thynk.Covid19Pcr.Application.DTOs.Response;
using Thynk.Covid19Pcr.Application.Models.Request;
using Thynk.Covid19Pcr.Application.Models.ViewModels;

namespace Thynk.Covid19Pcr.Application.Interfaces.Service
{
    public interface IAdminService
    {
        ExecutedResult<List<VaccineTypesVm>> FetchVaccineTypes();
        ExecutedResult<PaginatedResponse> GetBookedCovidPcrTest(PaginatedRequest request);
        ExecutedResult<PaginatedResponse> GetCovidPcrTestResult(CovidTestResultRequest request);
        Task<ExecutedResult<string>> AssignSlotToTestLab(AssignSlotRequest request);
        Task<ExecutedResult<string>> AddVaccineType(AddVaccineTypeRequest request);
        ExecutedResult<PaginatedResponse> GetAvailableTestDays(TestDaysWithLabLocationRequest request);
        ExecutedResult<List<LocationsWithLabsVm>> GetLocationsWithTestLabs();
        Task<ExecutedResult<int>> AllocateMoreSpace(AllocateMoreSpaceRequest request);
        Task<ExecutedResult<TestBookingVm>> CompleteBookedTest(CompleteBookedTestRequest request);
        Task<ExecutedResult<TestDaysWithLabLocationVm>> GetAvailableTestDay(long id);
    }
}
