using System;

namespace Thynk.Covid19Pcr.Application.Models.ViewModels
{
    public class GetReportVm
    {
        public long Id { get; set; }
        public string ReportType { get; set; }
        public string ReportRange { get; set; }
        public string ReportStatus { get; set; }
        public DateTime? RequestedOn { get; set; }
        public DateTime? TreatedOn { get; set; }
        public DateTime? CancelledOn { get; set; }
    }
}
