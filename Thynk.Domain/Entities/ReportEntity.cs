using System;
using Thynk.Covid19Pcr.Domain.Enums;

namespace Thynk.Covid19Pcr.Domain.Entities
{
    public class ReportEntity : BaseEntity
    {

        public string ReportName { get; set; }

        public DateTime? TreatedOn { get; set; }

        public string ReportStatus { get; set; }

        public string RequestObject { get; set; }

        public string FileName { get; set; }

        public DateTime? From { get; set; }

        public DateTime? To { get; set; }

        public byte[] FileContent { get; set; }

        public string ContentType { get; set; }

        public Formats Format { get; set; }

        public bool IsExpired { get; set; }

        public DateTime? CancelledOn { get; set; }
    }
}
