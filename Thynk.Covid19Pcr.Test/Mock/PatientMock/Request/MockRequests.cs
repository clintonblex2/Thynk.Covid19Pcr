using Bogus;
using System;
using Thynk.Covid19Pcr.Application.Models.Request;

namespace Thynk.Covid19Pcr.Test.Mock.PatientMock.Request
{
    public static class MockRequests
    {
        public static AddVaccineTypeRequest MockAddVaccineTypeRequest()
        {
            var faker = new Faker<AddVaccineTypeRequest>()
                     .RuleFor(o => o.Description, f => f.Random.String(50))
                     .RuleFor(o => o.Name, "Moderna")
                     .RuleFor(o => o.RecommendedAge, f => 18)
                     .RuleFor(o => o.TotalSupplied, f => 50)
                     .RuleFor(o => o.Manufacturer, f => f.Random.String(20));

            return faker.Generate();
        }

        public static AllocateMoreSpaceRequest MockAllocateMoreSpaceRequest()
        {
            var faker = new Faker<AllocateMoreSpaceRequest>()
                .RuleFor(o => o.AvailableSpaceId, 1)
                .RuleFor(o => o.NewSlot, 50);

            return faker.Generate();
        }

        public static AssignSlotRequest MockAssignSlotRequest()
        {
            var faker = new Faker<AssignSlotRequest>()
                .RuleFor(o => o.SelectedDate, DateTime.Now)
                .RuleFor(o => o.Slot, 50)
                .RuleFor(o => o.TestLabId, 5);

            return faker.Generate();
        }
    }
}
