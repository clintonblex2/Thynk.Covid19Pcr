using System;
using Thynk.Covid19Pcr.Domain.Enums;

namespace Thynk.Covid19Pcr.Domain.Entities
{
    public class TestBookings : BaseEntity
    {
        public string BookingReference { get; set; }
        public long VaccineTypeId { get; set; }
        public VaccineTypes VaccineType { get; set; }
        public long PatientId { get; set; }
        public Patients Patient { get; set; }
        public long AvailableTestDayId { get; set; }
        public AvailableTestDays AvailableTestDay { get; set; }
        public TestBookingStatus BookingStatus { get; set; }
        public CovidTestResult TestResult { get; set; }

        public (bool, string) AddPatienceLabTestResult(CovidResultType resultType)
        {
            if (AvailableTestDay.AvailableDate.Date != DateTime.Now.Date)
                return (false, "The test date is not today");

            if (BookingStatus == TestBookingStatus.Cancelled || BookingStatus == TestBookingStatus.Confirmed)
                return (false, $"You can't add this lab test result because it's already {resultType}");

            TestResult = new CovidTestResult(resultType);
            AvailableTestDay.OpenSlots++;
            BookingStatus = TestBookingStatus.Confirmed;

            return (true, "Added test result");
        }
    }
}
