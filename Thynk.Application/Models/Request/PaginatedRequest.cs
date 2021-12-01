using System;
using System.ComponentModel.DataAnnotations;

namespace Thynk.Covid19Pcr.Application.Models.Request
{
    public class PaginatedRequest
    {
        [Required]
        public DateTime From { get; set; }
        [Required]
        public DateTime To { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Page must be a positive number")]
        public int Page { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Page size must be a positive number")]
        [Required]
        public int PageSize { get; set; }
    }
}
