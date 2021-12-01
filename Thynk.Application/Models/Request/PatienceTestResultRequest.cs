using System.ComponentModel.DataAnnotations;

namespace Thynk.Covid19Pcr.Application.Models.Request
{
    public class PatienceTestResultRequest
    {
        [Required(ErrorMessage = "Your booking reference is required")]
        public string BookingReference { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }
    }
}
