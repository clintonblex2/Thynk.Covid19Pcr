using System.ComponentModel.DataAnnotations;

namespace Thynk.Covid19Pcr.Application.Models.Request
{
    public class TestDaysWithLabLocationRequest
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Page must be a positive number")]
        public int Page { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Page size must be a positive number")]
        public int PageSize { get; set; }
    }
}
