using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading.Tasks;
using Thynk.Covid19Pcr.Application.DTOs.Response;
using Thynk.Covid19Pcr.Application.Interfaces.Service;
using Thynk.Covid19Pcr.Application.Models.Request;
using Thynk.Covid19Pcr.Application.Models.ViewModels;
using Thynk.Covid19Pcr.Domain.Enums;

namespace Thynk.Covid19Pcr.API.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ReportController : BaseApiController<ReportController>
    {
        public readonly IReportService _report;

        public ReportController(IReportService report)
        {
            _report = report;
        }

        /// <summary>
        /// GetReportTypes
        /// </summary>
        /// <returns></returns>   
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<List<string>>), (int)HttpStatusCode.OK)]
        [HttpGet("GetReportTypes")]
        public IActionResult GetReportTypes()
            => TransformResponse(_report.GetReportTypes());

        /// <summary>
        /// CreateReport
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>  
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.OK)]
        [HttpPost("CreateReport")]
        public async Task<IActionResult> CreateReport(ReportRequest request)
            => TransformResponse(await _report.CreateReport(request));

        /// <summary>
        /// CancelReport
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>  
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.OK)]
        [HttpGet("CancelReport/{id}")]
        public async Task<IActionResult> CancelReport([FromRoute, Required] long id)
            => TransformResponse(await _report.CancelReport(id));

        /// <summary>
        /// GetReports
        /// </summary>
        /// <returns></returns> 
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<IEnumerable<GetReportVm>>), (int)HttpStatusCode.OK)]
        [HttpGet("GetReports")]
        public async Task<IActionResult> GetReports()
            => TransformResponse(await _report.GetReports());

        /// <summary>
        /// DownloadReport
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>  
        [ProducesResponseType(typeof(ExecutedResult), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ExecutedResult<string>), (int)HttpStatusCode.OK)]
        [HttpGet("DownloadReport/{id}")]
        public async Task<IActionResult> DownloadReport([FromRoute, Required] long id)
        {
            var er = await _report.DownloadReport(id);

            if (er.Response != ResponseCode.Success || er.Result == null)
                return TransformResponse(er);

            return File(er.Result?.FileContent, er.Result?.ContentType, er.Result?.FileName);
        }
    }
}
