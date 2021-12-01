using Bogus;
using System;
using System.Collections.Generic;
using Thynk.Covid19Pcr.Domain.Entities;

namespace Thynk.Covid19Pcr.Application.RandomData
{
    public class VaccineTypeFaker : Faker<VaccineTypes>
    {
        long id = 1;
        int count = 0;
        int count2 = 0;
        private readonly List<string> vaccines = new() { "Pfizer-BioNTech", "Moderna", "Johnson & Johnson’s" };
        public VaccineTypeFaker()
        {
            RuleFor(o => o.Id, f => id++);
            RuleFor(o => o.IsApproved, f => f.Random.Bool());
            RuleFor(o => o.Name, f => vaccines[count++]);
            RuleFor(o => o.RecommendedAge, f => vaccines[count2++] == "Pfizer-BioNTech" ? 5 : 18);
            RuleFor(o => o.TotalSupplied, f => f.Random.Number(500, 1000));
            RuleFor(o => o.Description, f => f.Random.Words(20));
            RuleFor(o => o.CreatedOn, DateTime.Now);
            RuleFor(o => o.CreatedBy, f => f.Person.UserName);
        }
    }
}
