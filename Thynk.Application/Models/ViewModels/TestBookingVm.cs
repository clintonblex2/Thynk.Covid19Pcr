using System;

namespace Thynk.Covid19Pcr.Application.DTOs.Response
{
    public class TestBookingVm
    {
        public string BookingReference { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string TestLocation { get; set; }
        public DateTime TestDate { get; set; }
        public string TestLab { get; set; }
        public string VaccineType { get; set; }
        public string BookingStatus { get; set; }
    }
}
