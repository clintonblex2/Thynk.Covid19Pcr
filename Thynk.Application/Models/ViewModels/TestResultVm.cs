using System;

namespace Thynk.Covid19Pcr.Application.DTOs.Response
{
    public class TestResultVm
    {
        public string PatientName { get; set; }
        public string BookingReference { get; set; }
        public string TestLab { get; set; }
        public string TestLocation { get; set; }
        public string VaccineType { get; set; }
        public DateTime TestDate { get; set; }
        public string BookingStatus { get; set; }
        public string TestResult { get; set; }
    }
}
