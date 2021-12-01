using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Thynk.Covid19Pcr.Application.RandomData;
using Thynk.Covid19Pcr.Domain.Entities;
using Thynk.Covid19Pcr.Domain.Enums;

namespace Thynk.Covid19Pcr.Infrastructure.Configurations
{
    public class TestBookingConfiguration : IEntityTypeConfiguration<TestBookings>
    {
        readonly TestBookingFaker bookingFaker = new();

        public void Configure(EntityTypeBuilder<TestBookings> builder)
        {
            builder.Property(p => p.BookingReference).HasMaxLength(50);
            builder.Property(p => p.CreatedBy).HasMaxLength(100);
            builder.Property(p => p.LastModifiedBy).HasMaxLength(100);
            builder.OwnsOne(p => p.TestResult).ToTable(Keys.TableNames.CovidTestResult);
            builder.Property(p => p.BookingStatus).HasMaxLength(20)
            .HasConversion(x => x.ToString(), x => (TestBookingStatus)Enum.Parse(typeof(TestBookingStatus), x));

            builder.HasIndex(x => new { x.BookingReference });

            builder.HasData(bookingFaker.Generate(5).ToArray());
        }
    }
}
