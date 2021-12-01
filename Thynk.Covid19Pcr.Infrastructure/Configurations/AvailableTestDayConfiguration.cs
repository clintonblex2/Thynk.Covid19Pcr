using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thynk.Covid19Pcr.Application.RandomData;
using Thynk.Covid19Pcr.Domain.Entities;

namespace Thynk.Covid19Pcr.Infrastructure.Configurations
{
    public class AvailableTestDayConfiguration : IEntityTypeConfiguration<AvailableTestDays>
    {
        readonly AvailableTestDayFaker testDayFaker = new();

        public void Configure(EntityTypeBuilder<AvailableTestDays> builder)
        {
            builder.Property(p => p.CreatedBy).HasMaxLength(100);
            builder.Property(p => p.LastModifiedBy).HasMaxLength(100);

            builder.HasData(testDayFaker.Generate(10).ToArray());
        }
    }
}
