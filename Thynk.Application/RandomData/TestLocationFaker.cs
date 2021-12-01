using Bogus;
using System;
using System.Collections.Generic;
using Thynk.Covid19Pcr.Domain.Entities;

namespace Thynk.Covid19Pcr.Application.RandomData
{
    public class TestLocationFaker : Faker<TestLocations>
    {
        long id = 1;
        int index = 0;

        private readonly List<string> cities = new()
        {
            "Abuja",
            "Lagos",
            "Port-harcourt"
        };
        public TestLocationFaker()
        {
            RuleFor(o => o.Id, f => id++);
            RuleFor(o => o.IsOperational, true);
            RuleFor(o => o.City, f => cities[index++]);
            RuleFor(o => o.Country, "Nigeria");
            RuleFor(o => o.CreatedOn, DateTime.Now);
            RuleFor(o => o.CreatedBy, f => f.Person.UserName);
        }
    }
}
