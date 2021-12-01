using System;
using System.ComponentModel.DataAnnotations;

namespace Thynk.Covid19Pcr.Application.Models.Request
{
    public class BookingRequest
    {
        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Lastname is required")]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage ="Phone number is required")]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public long VaccineTypeId { get; set; }
        [Required(ErrorMessage ="Select your gender")]
        public string Gender { get; set; }
        [Required]
        public long AppointmentDayId { get; set; }
    }
}
