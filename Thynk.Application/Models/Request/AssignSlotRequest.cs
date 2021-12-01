using System;
using System.ComponentModel.DataAnnotations;

namespace Thynk.Covid19Pcr.Application.Models.Request
{
    public class AssignSlotRequest
    {
        [Required(ErrorMessage = "Slot is Required")]
        [Range(1, int.MaxValue, ErrorMessage = "Slot must be a positive number")]
        public int Slot { get; set; }
        [Required]
        public long TestLabId { get; set; }
        [Required]
        public DateTime SelectedDate { get; set; }
    }
}
