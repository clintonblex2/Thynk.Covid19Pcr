using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Thynk.Covid19Pcr.Domain.Enums;
using Thynk.Covid19Pcr.Domain.Helpers;

namespace Thynk.Covid19Pcr.Domain.Entities
{
    public class Patients : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        
        public ICollection<TestBookings> TestBookings { get; set; } = new Collection<TestBookings>();

        public void SetAge()
        {
            Age = DateOfBirth.HasValue ? DateTime.Now.AddYears(-DateOfBirth.Value.Year).Year : 0;
        }

        public (bool, string) CreateTestBooking(AvailableTestDays selectedDay, VaccineTypes vaccineType)
        {
            if (TestBookings.Any(x => x.BookingStatus == TestBookingStatus.Booked && x.AvailableTestDayId == selectedDay.Id))
                return (false, "You've already scheduled a Covid-19 test appointment on the selected day");

            (bool, string) validateSelectedDay = ValidateSelectedDay(selectedDay);
            if (!validateSelectedDay.Item1)
                return (validateSelectedDay.Item1, validateSelectedDay.Item2);

            selectedDay.OpenSlots--;

            TestBookings booking = new()
            {
                BookingReference = Utils.RandomString(12),
                VaccineTypeId = vaccineType.Id,
                AvailableTestDayId = selectedDay.Id,
                BookingStatus = TestBookingStatus.Booked,
                Patient = this,
            };

            TestBookings.Add(booking);

            return (true, booking.BookingReference);
        }

        public static (bool, string) ValidateSelectedDay(AvailableTestDays selectedDay)
        {
            if (selectedDay.OpenSlots == 0)
                return (false, "No available slot for the selected day");

            if (!selectedDay.TestLab.IsActive)
                return (false, "The allocated test lab for the selected day is currently unavailable");

            if (selectedDay.AvailableDate < DateTime.Now.Date)
                return (false, "You cannot book a test appointment in the past. Kindly enter a future date");

            return (true, "Validated");
        }
    }
}
