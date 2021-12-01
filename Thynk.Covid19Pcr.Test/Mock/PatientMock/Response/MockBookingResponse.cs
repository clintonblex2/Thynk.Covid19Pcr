using Bogus;
using System;
using System.Collections.Generic;
using Thynk.Covid19Pcr.Domain.Entities;
using Thynk.Covid19Pcr.Domain.Enums;

namespace Thynk.Covid19Pcr.Test.Mock.PatientMock.Response
{
    public static class MockBookingResponse
    {
        public static VaccineTypes MockInvalidGenderBookingResponse()
        {
            var vaccineFaker = new Faker<VaccineTypes>()
                     .RuleFor(o => o.Id, f => 1)
                     .RuleFor(o => o.Name, "Pfizer-BioNTech")
                     .RuleFor(o => o.RecommendedAge, f => 5)
                     .RuleFor(o => o.TotalSupplied, f => 50)
                     .RuleFor(o => o.CreatedOn, DateTime.Now);

            return vaccineFaker.Generate();
        }

        public static VaccineTypes MockModernaBookingResponse()
        {
            var vaccineFaker = new Faker<VaccineTypes>()
                     .RuleFor(o => o.Id, f => 1)
                     .RuleFor(o => o.Name, "Moderna")
                     .RuleFor(o => o.RecommendedAge, f => 18)
                     .RuleFor(o => o.TotalSupplied, f => 50)
                     .RuleFor(o => o.CreatedOn, DateTime.Now);

            return vaccineFaker.Generate();
        }

        public static IList<VaccineTypes> MockVaccineTypes()
        {
            IList<VaccineTypes> items = new List<VaccineTypes>
            {
                MockInvalidGenderBookingResponse(),
                MockModernaBookingResponse()
            };
            return items;
        }

        public static VaccineTypes MockPfizerBookingResponse()
        {
            var vaccineFaker = new Faker<VaccineTypes>()
                     .RuleFor(o => o.Id, f => 1)
                     .RuleFor(o => o.Name, "Pfizer-BioNTech")
                     .RuleFor(o => o.RecommendedAge, f => 5)
                     .RuleFor(o => o.TotalSupplied, f => 650)
                     .RuleFor(o => o.CreatedOn, DateTime.Now);

            return vaccineFaker.Generate();
        }

        public static Patients MockPatientResponse()
        {
            var faker = new Faker<Patients>()
                     .RuleFor(o => o.Id, f => 1)
                     .RuleFor(o => o.FirstName, f => f.Person.FirstName)
                     .RuleFor(o => o.LastName, f => f.Person.LastName)
                     .RuleFor(o => o.PhoneNumber, "09079910094")
                     .RuleFor(o => o.Email, f => f.Person.Email)
                     .RuleFor(o => o.DateOfBirth, DateTime.Now.AddYears(-20))
                     .RuleFor(o => o.Age, 20)
                     .RuleFor(o => o.CreatedBy, f => f.Person.UserName)
                     .RuleFor(o => o.CreatedOn, DateTime.Now)
                     .RuleFor(o => o.TestBookings, f => new List<TestBookings>
                     {
                         new TestBookings
                         {
                             Id = 1,
                             BookingStatus = TestBookingStatus.Booked,
                             AvailableTestDayId = 1
                         }
                     });

            return faker.Generate();
        }

        public static Patients MockPatient2Response()
        {
            var faker = new Faker<Patients>()
                     .RuleFor(o => o.Id, f => 1)
                     .RuleFor(o => o.FirstName, f => f.Person.FirstName)
                     .RuleFor(o => o.LastName, f => f.Person.LastName)
                     .RuleFor(o => o.PhoneNumber, "09079910094")
                     .RuleFor(o => o.Email, f => f.Person.Email)
                     .RuleFor(o => o.DateOfBirth, DateTime.Now.AddYears(-20))
                     .RuleFor(o => o.Age, 20)
                     .RuleFor(o => o.CreatedBy, f => f.Person.UserName)
                     .RuleFor(o => o.CreatedOn, DateTime.Now)
                     .RuleFor(o => o.TestBookings, f => new List<TestBookings>
                     {
                         new TestBookings
                         {
                             Id = 1,
                             BookingStatus = 0,
                             AvailableTestDayId = 2
                         }
                     });

            return faker.Generate();
        }

        public static AvailableTestDays MockAvailableTestDayWithZeroSlotResponse()
        {
            var testDay = new Faker<AvailableTestDays>()
                .RuleFor(o => o.Id, f => 2)
                .RuleFor(o => o.AvailableDate, DateTime.Now.AddDays(2))
                .RuleFor(o => o.CreatedBy, f => f.Person.UserName)
                .RuleFor(o => o.CreatedOn, DateTime.Now)
                .RuleFor(o => o.OpenSlots, f => 0)
                .RuleFor(o => o.TestLabId, f => 1)
                .RuleFor(o => o.TestLab, f => new TestLabs
                {
                    Id = 1,
                    IsActive = false,
                    CreatedOn = DateTime.Now,
                    CreatedBy = f.Person.UserName,
                    LabName = "Cornelius Test Lab",
                    TestLocationId = 1,
                    TestLocation = new TestLocations
                    {
                        City = "Lagos",
                        Country = "Nigeria",
                        CreatedOn = DateTime.Now,
                        Id = 1,
                        IsOperational = true,
                        CreatedBy = f.Person.UserName
                    }
                });

            return testDay.Generate();
        }

        public static AvailableTestDays MockAvailableTestDayWithInactiveLabResponse()
        {
            var testDay = new Faker<AvailableTestDays>()
                .RuleFor(o => o.Id, f => 2)
                .RuleFor(o => o.AvailableDate, DateTime.Now.AddDays(2))
                .RuleFor(o => o.CreatedBy, f => f.Person.UserName)
                .RuleFor(o => o.CreatedOn, DateTime.Now)
                .RuleFor(o => o.OpenSlots, f => 440)
                .RuleFor(o => o.TestLabId, f => 1)
                .RuleFor(o => o.TestLab, f => new TestLabs
                {
                    Id = 1,
                    IsActive = false,
                    CreatedOn = DateTime.Now,
                    CreatedBy = f.Person.UserName,
                    LabName = "Cornelius Test Lab",
                    TestLocationId = 1,
                    TestLocation = new TestLocations
                    {
                        City = "Lagos",
                        Country = "Nigeria",
                        CreatedOn = DateTime.Now,
                        Id = 1,
                        IsOperational = true,
                        CreatedBy = f.Person.UserName
                    }
                });

            return testDay.Generate();
        }

        public static AvailableTestDays MockAvailableTestDayWithPastDateResponse()
        {
            var testDay = new Faker<AvailableTestDays>()
                .RuleFor(o => o.Id, f => 2)
                .RuleFor(o => o.AvailableDate, DateTime.Now.AddDays(-2))
                .RuleFor(o => o.CreatedBy, f => f.Person.UserName)
                .RuleFor(o => o.CreatedOn, DateTime.Now)
                .RuleFor(o => o.OpenSlots, f => 440)
                .RuleFor(o => o.TestLabId, f => 1)
                .RuleFor(o => o.TestLab, f => new TestLabs
                {
                    Id = 1,
                    IsActive = true,
                    CreatedOn = DateTime.Now,
                    CreatedBy = f.Person.UserName,
                    LabName = "Cornelius Test Lab",
                    TestLocationId = 1,
                    TestLocation = new TestLocations
                    {
                        City = "Lagos",
                        Country = "Nigeria",
                        CreatedOn = DateTime.Now,
                        Id = 1,
                        IsOperational = true,
                        CreatedBy = f.Person.UserName
                    }
                });

            return testDay.Generate();
        }

        public static AvailableTestDays MockAvailableTestDayWithValidResponse()
        {
            var testDay = new Faker<AvailableTestDays>()
                .RuleFor(o => o.Id, f => 2)
                .RuleFor(o => o.AvailableDate, DateTime.Now.AddDays(2))
                .RuleFor(o => o.CreatedBy, f => f.Person.UserName)
                .RuleFor(o => o.CreatedOn, DateTime.Now)
                .RuleFor(o => o.OpenSlots, f => 440)
                .RuleFor(o => o.TestLabId, f => 1)
                .RuleFor(o => o.TestLab, f => new TestLabs
                {
                    Id = 1,
                    IsActive = true,
                    CreatedOn = DateTime.Now,
                    CreatedBy = f.Person.UserName,
                    LabName = "Cornelius Test Lab",
                    TestLocationId = 1,
                    TestLocation = new TestLocations
                    {
                        City = "Lagos",
                        Country = "Nigeria",
                        CreatedOn = DateTime.Now,
                        Id = 1,
                        IsOperational = true,
                        CreatedBy = f.Person.UserName
                    }
                });

            return testDay.Generate();
        }

        public static AvailableTestDays MockAvailableTestDayWithSlotsResponse()
        {
            var testDay = new Faker<AvailableTestDays>()
                .RuleFor(o => o.Id, f => 1)
                .RuleFor(o => o.AvailableDate, DateTime.Now.AddDays(1))
                .RuleFor(o => o.CreatedBy, f => f.Person.UserName)
                .RuleFor(o => o.CreatedOn, DateTime.Now)
                .RuleFor(o => o.OpenSlots, f => 20)
                .RuleFor(o => o.TestLabId, f => 1)
                .RuleFor(o => o.TestLab, f => new TestLabs
                {
                    Id = 1,
                    IsActive = true,
                    CreatedOn = DateTime.Now,
                    CreatedBy = f.Person.UserName,
                    LabName = "Cornelius Test Lab",
                    TestLocationId = 1,
                    TestLocation = new TestLocations
                    {
                        City = "Lagos",
                        Country = "Nigeria",
                        CreatedOn = DateTime.Now,
                        Id = 1,
                        IsOperational = true,
                        CreatedBy = f.Person.UserName
                    }
                });

            return testDay.Generate();
        }

        public static TestBookings MockBookedTestBookingsResponse()
        {
            var testDay = new Faker<TestBookings>()
                .RuleFor(o => o.Id, f => 1)
                .RuleFor(o => o.BookingReference, "ABCDE12345")
                .RuleFor(o => o.BookingStatus, TestBookingStatus.Booked)
                .RuleFor(o => o.CreatedOn, DateTime.Now)
                .RuleFor(o => o.PatientId, 1)
                .RuleFor(o => o.AvailableTestDay, f => new AvailableTestDays
                {
                    Id = 1,
                    AvailableDate = DateTime.Now.AddDays(5),
                    CreatedOn = DateTime.Now,
                    CreatedBy = f.Person.UserName,
                    TestLabId = 1,
                    OpenSlots = 207,
                    TestLab = new TestLabs
                    {
                        LabName = "Smart Lab 1",
                        IsActive = true,
                        CreatedOn = DateTime.Now,
                        Id = 1,
                        CreatedBy = f.Person.UserName
                    }
                });

            return testDay.Generate();
        }

        public static TestBookings MockBookingWithTestdayResponse()
        {
            Faker<TestBookings> faker = new Faker<TestBookings>()
                .RuleFor(o => o.Id, f => 1)
                .RuleFor(o => o.BookingReference, "ABCDE12345")
                .RuleFor(o => o.BookingStatus, TestBookingStatus.Booked)
                .RuleFor(o => o.CreatedOn, DateTime.Now)
                .RuleFor(o => o.PatientId, 1)
                .RuleFor(o => o.AvailableTestDay, f => new AvailableTestDays
                {
                    Id = 1,
                    AvailableDate = DateTime.Now.AddDays(5),
                    CreatedOn = DateTime.Now,
                    CreatedBy = f.Person.UserName,
                    TestLabId = 1,
                    OpenSlots = 207,
                    TestLab = new TestLabs
                    {
                        LabName = "Smart Lab 1",
                        IsActive = true,
                        CreatedOn = DateTime.Now,
                        Id = 1,
                        CreatedBy = f.Person.UserName
                    }
                });


            return faker.Generate();
        }

        public static TestLocations MockTestLocations()
        {
            var location = new Faker<TestLocations>()
                .RuleFor(o => o.IsOperational, false)
                .RuleFor(o => o.City, "Abuja")
                .RuleFor(o => o.LabsInLocation, f => new List<TestLabs>
                {
                   new TestLabs
                   {
                       Id = 1
                   }
                });

            return location.Generate();
        }

        public static IList<TestLocations> MockEnumerableTestLocationResponse()
        {
            IList<TestLocations> items = new List<TestLocations>();
            items.Add(MockTestLocations());
            return items;
        }

        public static TestBookings MockCancelledTestBookingsResponse()
        {
            var testDay = new Faker<TestBookings>()
                .RuleFor(o => o.Id, f => 1)
                .RuleFor(o => o.BookingReference, "ABCDE12345")
                .RuleFor(o => o.BookingStatus, TestBookingStatus.Cancelled)
                .RuleFor(o => o.CreatedOn, DateTime.Now)
                .RuleFor(o => o.PatientId, 1)
                .RuleFor(o => o.AvailableTestDay, f => new AvailableTestDays
                {
                    Id = 1,
                    AvailableDate = DateTime.Now.AddDays(5),
                    CreatedOn = DateTime.Now,
                    CreatedBy = f.Person.UserName,
                    TestLabId = 1,
                    OpenSlots = 207,
                    TestLab = new TestLabs
                    {
                        LabName = "Smart Lab 1",
                        IsActive = true,
                        CreatedOn = DateTime.Now,
                        Id = 1,
                        CreatedBy = f.Person.UserName
                    }
                });

            return testDay.Generate();
        }

        public static TestBookings MockConfirmedTestBookingsResponse()
        {
            var testDay = new Faker<TestBookings>()
                .RuleFor(o => o.Id, f => 1)
                .RuleFor(o => o.BookingReference, "ABCDE12345")
                .RuleFor(o => o.BookingStatus, TestBookingStatus.Confirmed)
                .RuleFor(o => o.CreatedOn, DateTime.Now)
                .RuleFor(o => o.PatientId, 1)
                .RuleFor(o => o.AvailableTestDay, f => new AvailableTestDays
                {
                    Id = 1,
                    AvailableDate = DateTime.Now.AddDays(5),
                    CreatedOn = DateTime.Now,
                    CreatedBy = f.Person.UserName,
                    TestLabId = 1,
                    OpenSlots = 207,
                    TestLab = new TestLabs
                    {
                        LabName = "Smart Lab 1",
                        IsActive = true,
                        CreatedOn = DateTime.Now,
                        Id = 1,
                        CreatedBy = f.Person.UserName
                    }
                });

            return testDay.Generate();
        }

        public static TestLabs MockTestLabsResponse()
        {
            var testLab = new Faker<TestLabs>()
                .RuleFor(o => o.Id, 1);

            return testLab.Generate();
        }
    }
}
