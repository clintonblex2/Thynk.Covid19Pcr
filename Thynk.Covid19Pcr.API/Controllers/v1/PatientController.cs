using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading.Tasks;
using Thynk.Covid19Pcr.Application.DTOs.Response;
using Thynk.Covid19Pcr.Application.Interfaces.Service;
using Thynk.Covid19Pcr.Application.Models.Request;
using Thynk.Covid19Pcr.Application.Models.ViewModels;
using Thynk.Covid19Pcr.Domain.Entities;

namespace Thynk.Covid19Pcr.API.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PatientController : BaseApiController<PatientController>
    {
        private readonly IPatientService _patience;

        public PatientController(IPatientService patience)
        {
            _patience = patience;
        }

        /// <summary>
        /// GetGender
        /// </summary>
        /// <returns></returns>  
        [ProducesResponseType(typeof(ExecutedResult), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<List<string>>), (int)HttpStatusCode.OK)]
        [HttpGet("GetGender")]
        public IActionResult GetGender()
            => TransformResponse(_patience.GetGender());

        /// <summary>
        /// GetVaccineTypes
        /// </summary>
        /// <returns></returns>  
        [ProducesResponseType(typeof(ExecutedResult), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<List<VaccineTypePatienceVm>>), (int)HttpStatusCode.OK)]
        [HttpGet("GetVaccineTypes")]
        public async Task<IActionResult> GetVaccineTypes()
            => TransformResponse(await _patience.GetVaccineTypes());

        /// <summary>
        /// GetLabLocations
        /// </summary>
        /// <returns></returns>  
        [ProducesResponseType(typeof(ExecutedResult), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<TestLocationVm>), (int)HttpStatusCode.OK)]
        [HttpGet("GetLabLocations")]
        public IActionResult GetLabLocations()
            => TransformResponse(_patience.GetLabLocations());

        /// <summary>
        /// BookCovidPcrTest
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns> 
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.OK)]
        [HttpPost("BookCovidPcrTest")]
        public async Task<IActionResult> BookCovidPcrTest(BookingRequest request)
            => TransformResponse(await _patience.BookCovidPcrTest(request));
        
        /// <summary>
        /// CancelBookedCovidPcrTest
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns> 
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<TestBookings>), (int)HttpStatusCode.OK)]
        [HttpPost("CancelBookedCovidPcrTest")]
        public async Task<IActionResult> CancelBookedCovidPcrTest(CancelBookingRequest request)
            => TransformResponse(await _patience.CancelBookedCovidPcrTest(request));
        

        /// <summary>
        /// GetBookedCovidPcrTest
        /// </summary>
        /// <param name="bookingReference"></param>
        /// <returns></returns> 
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<TestBookingVm>), (int)HttpStatusCode.OK)]
        [HttpGet("GetBookedCovidPcrTest/{bookingReference}")]
        public IActionResult GetBookedCovidPcrTest([FromRoute, Required]string bookingReference)
            => TransformResponse(_patience.GetBookedCovidPcrTest(bookingReference));

        /// <summary>
        /// CovidPcrTestResult
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns> 
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<TestResultVm>), (int)HttpStatusCode.OK)]
        [HttpPost("CovidPcrTestResult")]
        public IActionResult CovidPcrTestResult(PatienceTestResultRequest request)
            => TransformResponse(_patience.GetPatienceTestResult(request));
        
    }
}
