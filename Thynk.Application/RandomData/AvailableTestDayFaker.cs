using Bogus;
using System;
using Thynk.Covid19Pcr.Domain.Entities;

namespace Thynk.Covid19Pcr.Application.RandomData
{
    public class AvailableTestDayFaker : Faker<AvailableTestDays>
    {
        long id = 1;
        
        public AvailableTestDayFaker()
        {
            RuleFor(o => o.Id, f => id++);
            RuleFor(o => o.AvailableDate, DateTime.Now.AddDays(id++));
            RuleFor(o => o.TestLabId, f => f.Random.Number(1, 11));
            RuleFor(o => o.OpenSlots, f => f.Random.Number(50, 100));
            RuleFor(o => o.CreatedOn, DateTime.Now);
            RuleFor(o => o.CreatedBy, f => f.Person.UserName);
        }
    }
}
