using System.Collections.Generic;
using System.Threading.Tasks;
using Thynk.Covid19Pcr.Application.DTOs.Response;
using Thynk.Covid19Pcr.Application.Models.Request;
using Thynk.Covid19Pcr.Application.Models.ViewModels;
using Thynk.Covid19Pcr.Domain.Entities;

namespace Thynk.Covid19Pcr.Application.Interfaces.Service
{
    public interface IReportService
    {
        Task<ExecutedResult<string>> CreateReport(ReportRequest request);
        Task<ExecutedResult<ReportEntity>> DownloadReport(long Id);
        Task<ExecutedResult<IEnumerable<GetReportVm>>> GetReports();
        Task<ExecutedResult<string>> CancelReport(long id);
        ExecutedResult<List<string>> GetReportTypes();
        Task ReportGenerator();
    }
}
