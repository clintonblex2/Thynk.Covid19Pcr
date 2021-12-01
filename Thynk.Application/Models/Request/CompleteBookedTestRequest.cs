using System.ComponentModel.DataAnnotations;
using Thynk.Covid19Pcr.Domain.Enums;

namespace Thynk.Covid19Pcr.Application.Models.Request
{
    public class CompleteBookedTestRequest
    {
        public CovidResultType TestResultType { get; set; }
        [Required]
        public string BookingReference { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
