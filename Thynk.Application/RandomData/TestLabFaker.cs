using Bogus;
using System;
using System.Collections.Generic;
using Thynk.Covid19Pcr.Domain.Entities;

namespace Thynk.Covid19Pcr.Application.RandomData
{
    public class TestLabFaker : Faker<TestLabs>
    {
        long id = 1;
        int count = 0;
        private readonly List<string> labs = new() 
        {
            "Medbury Services Limited",
            "Sahel Lab",
            "Epiconsult clinic and Diagnostics Center",
            "Centolab",
            "A-Medik Molecular Laboratory",
            "Cedarcrest Hospital Molecular Laboratory",
            "Clina Lancet",
            "Biologix Support Services",
            "Clinix Healthcare",
            "Reddington Zainelab",
            "Medbury Services Limited"
        };

        public TestLabFaker()
        {
            RuleFor(o => o.Id, f => id++);
            RuleFor(o => o.IsActive, true);
            RuleFor(o => o.LabName, f => labs[count++]);
            RuleFor(o => o.TestLocationId, f => f.Random.Number(1, 3));
            RuleFor(o => o.CreatedOn, DateTime.Now);
            RuleFor(o => o.CreatedBy, f => f.Person.UserName);
        }
    }
}
