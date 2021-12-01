using System.ComponentModel.DataAnnotations;

namespace Thynk.Covid19Pcr.Application.Models.Request
{
    public class ReportRequest : PaginatedRequest
    {
        [Required]
        public string ReportType { get; set; }
    }
}
