using Bogus;
using System;
using Thynk.Covid19Pcr.Domain.Entities;
using Thynk.Covid19Pcr.Domain.Enums;

namespace Thynk.Covid19Pcr.Application.RandomData
{
    public class PatientFaker : Faker<Patients>
    {
        long id = 1;

        public PatientFaker()
        {
            RuleFor(o => o.Id, f => id++);
            RuleFor(o => o.Gender, f => f.PickRandom<Gender>());
            RuleFor(o => o.FirstName, f => f.Name.FirstName());
            RuleFor(o => o.LastName, f => f.Name.LastName());
            RuleFor(o => o.DateOfBirth, f => f.Person.DateOfBirth);
            RuleFor(o => o.Email, f => f.Person.Email);
            RuleFor(o => o.PhoneNumber, f => f.Phone.PhoneNumber("070########"));
            RuleFor(o => o.CreatedOn, DateTime.Now);
            RuleFor(o => o.CreatedBy, f => f.Person.UserName);
        }
    }
}
