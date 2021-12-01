using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading.Tasks;
using Thynk.Covid19Pcr.Application.DTOs.Response;
using Thynk.Covid19Pcr.Application.Interfaces.Service;
using Thynk.Covid19Pcr.Application.Models.Request;
using Thynk.Covid19Pcr.Application.Models.ViewModels;

namespace Thynk.Covid19Pcr.API.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AdminController : BaseApiController<AdminController>
    {
        private readonly IAdminService _admin;
        public AdminController(IAdminService admin)
        {
            _admin = admin;
        }

        /// <summary>
        /// FetchVaccineTypes
        /// </summary>
        /// <returns></returns>  
        [ProducesResponseType(typeof(ExecutedResult), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<List<VaccineTypesVm>>), (int)HttpStatusCode.OK)]
        [HttpGet("FetchVaccineTypes")]
        public IActionResult FetchVaccineTypes()
            => TransformResponse(_admin.FetchVaccineTypes());

        /// <summary>
        /// GetLocationsWithTestLabs
        /// </summary>
        /// <returns></returns>  
        [ProducesResponseType(typeof(ExecutedResult), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<List<LocationsWithLabsVm>>), (int)HttpStatusCode.OK)]
        [HttpGet("GetLocationsWithTestLabs")]
        public IActionResult GetLocationsWithTestLabs()
            => TransformResponse(_admin.GetLocationsWithTestLabs());

        /// <summary>
        /// GetAvailableTestDay
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>  
        [ProducesResponseType(typeof(ExecutedResult), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<List<LocationsWithLabsVm>>), (int)HttpStatusCode.OK)]
        [HttpGet("GetAvailableTestDay/{id}")]
        public async Task<IActionResult> GetAvailableTestDay([FromRoute, Required]long id)
            => TransformResponse(await _admin.GetAvailableTestDay(id));

        /// <summary>
        /// AvailableTestDays
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>  
        [ProducesResponseType(typeof(ExecutedResult), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<PaginatedResponse>), (int)HttpStatusCode.OK)]
        [HttpGet("AvailableTestDays")]
        public IActionResult AvailableTestDays([FromQuery] TestDaysWithLabLocationRequest request)
            => TransformResponse(_admin.GetAvailableTestDays(request));

        /// <summary>
        /// AddVaccineType
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns> 
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.OK)]
        [HttpPost("AddVaccineType")]
        public async Task<IActionResult> AddVaccineType(AddVaccineTypeRequest request)
            => TransformResponse(await _admin.AddVaccineType(request));

        /// <summary>
        /// AllocateMoreSpace
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns> 
        [ProducesResponseType(typeof(ExecutedResult<int>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<int>), (int)HttpStatusCode.OK)]
        [HttpPost("AllocateMoreSpace")]
        public async Task<IActionResult> AllocateMoreSpace(AllocateMoreSpaceRequest request)
            => TransformResponse(await _admin.AllocateMoreSpace(request));

        /// <summary>
        /// AssignSlotToTestLab
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns> 
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.OK)]
        [HttpPost("AssignSlotToTestLab")]
        public async Task<IActionResult> AssignSlotToTestLab(AssignSlotRequest request)
            => TransformResponse(await _admin.AssignSlotToTestLab(request));

        /// <summary>
        /// CompleteBookedTest
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns> 
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<TestBookingVm>), (int)HttpStatusCode.OK)]
        [HttpPost("CompleteBookedTest")]
        public async Task<IActionResult> CompleteBookedTest(CompleteBookedTestRequest request)
            => TransformResponse(await _admin.CompleteBookedTest(request));

        /// <summary>
        /// GetBookedCovidPcrTest
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns> 
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<PaginatedResponse>), (int)HttpStatusCode.OK)]
        [HttpGet("GetBookedCovidPcrTest")]
        public IActionResult GetBookedCovidPcrTest([FromQuery]PaginatedRequest request)
            => TransformResponse(_admin.GetBookedCovidPcrTest(request));

        /// <summary>
        /// GetCovidPcrTestResult
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns> 
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<PaginatedResponse>), (int)HttpStatusCode.OK)]
        [HttpGet("GetCovidPcrTestResult")]
        public IActionResult GetCovidPcrTestResult([FromQuery]CovidTestResultRequest request)
            => TransformResponse(_admin.GetCovidPcrTestResult(request));
    }
}
