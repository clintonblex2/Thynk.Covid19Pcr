using Bogus;
using System;
using Thynk.Covid19Pcr.Application.Models.Request;

namespace Thynk.Covid19Pcr.Test.Mock.PatientMock
{
    public static class MockBookingRequest
    {
        public static BookingRequest MockInvalidGenderBookingRequest()
        {
            var bookFaker = new Faker<BookingRequest>()
                     .RuleFor(o => o.AppointmentDayId, 1)
                     .RuleFor(o => o.DateOfBirth, DateTime.Now.AddYears(-10))
                     .RuleFor(o => o.Email, f => f.Person.Email)
                     .RuleFor(o => o.FirstName, f => f.Person.FirstName)
                     .RuleFor(o => o.LastName, f => f.Person.LastName)
                     .RuleFor(o => o.PhoneNumber, f => f.Person.Phone)
                     .RuleFor(o => o.VaccineTypeId, 1)
                     .RuleFor(o => o.Gender, "Others");

            return bookFaker.Generate();
        }

        public static BookingRequest MockValidGenderBookingRequest()
        {
            var bookFaker = new Faker<BookingRequest>()
                     .RuleFor(o => o.AppointmentDayId, 1)
                     .RuleFor(o => o.DateOfBirth, DateTime.Now.AddYears(-10))
                     .RuleFor(o => o.Email, f => f.Person.Email)
                     .RuleFor(o => o.FirstName, f => f.Person.FirstName)
                     .RuleFor(o => o.LastName, f => f.Person.LastName)
                     .RuleFor(o => o.PhoneNumber, "09079910094")
                     .RuleFor(o => o.VaccineTypeId, 1)
                     .RuleFor(o => o.Gender, "Male");

            return bookFaker.Generate();
        }

        public static BookingRequest MockInValidAgeBookingRequest()
        {
            var bookFaker = new Faker<BookingRequest>()
                     .RuleFor(o => o.AppointmentDayId, 1)
                     .RuleFor(o => o.DateOfBirth, DateTime.Now.AddYears(-4))
                     .RuleFor(o => o.Email, f => f.Person.Email)
                     .RuleFor(o => o.FirstName, f => f.Person.FirstName)
                     .RuleFor(o => o.LastName, f => f.Person.LastName)
                     .RuleFor(o => o.PhoneNumber, f => f.Person.Phone)
                     .RuleFor(o => o.VaccineTypeId, 1)
                     .RuleFor(o => o.Gender, "Male");

            return bookFaker.Generate();
        }

        public static BookingRequest MockRecommendedAgeBookingRequest()
        {
            var bookFaker = new Faker<BookingRequest>()
                     .RuleFor(o => o.AppointmentDayId, 1)
                     .RuleFor(o => o.DateOfBirth, DateTime.Now.AddYears(-15))
                     .RuleFor(o => o.Email, f => f.Person.Email)
                     .RuleFor(o => o.FirstName, f => f.Person.FirstName)
                     .RuleFor(o => o.LastName, f => f.Person.LastName)
                     .RuleFor(o => o.PhoneNumber, f => f.Person.Phone)
                     .RuleFor(o => o.VaccineTypeId, 1)
                     .RuleFor(o => o.Gender, "Male");

            return bookFaker.Generate();
        }
    }
}
