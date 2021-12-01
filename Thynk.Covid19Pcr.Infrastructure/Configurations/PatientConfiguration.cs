using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Thynk.Covid19Pcr.Application.RandomData;
using Thynk.Covid19Pcr.Domain.Entities;
using Thynk.Covid19Pcr.Domain.Enums;
using Thynk.Covid19Pcr.Infrastructure.Keys;

namespace Thynk.Covid19Pcr.Infrastructure.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patients>
    {
        readonly PatientFaker patient = new();

        public void Configure(EntityTypeBuilder<Patients> builder)
        {
            builder.ToTable(TableNames.Patient);
            builder.Property(p => p.FirstName).HasMaxLength(50);
            builder.Property(p => p.LastName).HasMaxLength(50);
            builder.Property(p => p.PhoneNumber).HasMaxLength(50);
            builder.Property(p => p.Email).HasMaxLength(100);
            builder.Property(p => p.CreatedBy).HasMaxLength(100);
            builder.Property(p => p.LastModifiedBy).HasMaxLength(100);
            builder.Property(p => p.Gender).HasMaxLength(10)
                .HasConversion(x => x.ToString(), x => (Gender)Enum.Parse(typeof(Gender), x));

            builder.HasIndex(x => new { x.PhoneNumber, x.Email });

            builder.HasData(patient.Generate(20).ToArray());


        }
    }
}
