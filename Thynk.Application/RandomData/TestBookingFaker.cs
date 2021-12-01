using Bogus;
using System;
using Thynk.Covid19Pcr.Domain.Entities;
using Thynk.Covid19Pcr.Domain.Enums;

namespace Thynk.Covid19Pcr.Application.RandomData
{
    public class TestBookingFaker : Faker<TestBookings>
    {
        long id = 1;

        public TestBookingFaker()
        {
            RuleFor(o => o.Id, f => id++);
            RuleFor(o => o.AvailableTestDayId, f => f.Random.Number(2, 10));
            RuleFor(o => o.BookingReference, f => f.Random.AlphaNumeric(10).ToUpper());
            RuleFor(o => o.BookingStatus, TestBookingStatus.Booked);
            RuleFor(o => o.PatientId, f => f.Random.Number(1, 10));
            RuleFor(o => o.VaccineTypeId, f => f.Random.Number(1, 3));
            RuleFor(o => o.CreatedOn, DateTime.Now);
            RuleFor(o => o.CreatedBy, f => f.Person.UserName);
        }
    }
}
