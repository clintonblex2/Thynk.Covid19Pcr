namespace Thynk.Covid19Pcr.Application.Models.Request
{
    public class CancelBookingRequest
    {
        public string BookingReference { get; set; }
        public string PhoneNumber { get; set; }
    }
}
