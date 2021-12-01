using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thynk.Covid19Pcr.Application.RandomData;
using Thynk.Covid19Pcr.Domain.Entities;

namespace Thynk.Covid19Pcr.Infrastructure.Configurations
{
    public class TestLocationConfiguration : IEntityTypeConfiguration<TestLocations>
    {
        readonly TestLocationFaker testLocationFaker = new();

        public void Configure(EntityTypeBuilder<TestLocations> builder)
        {
            builder.Property(p => p.City).HasMaxLength(50);
            builder.Property(p => p.Country).HasMaxLength(50);
            builder.Property(p => p.CreatedBy).HasMaxLength(100);
            builder.Property(p => p.LastModifiedBy).HasMaxLength(100);

            builder.HasIndex(x => new { x.City });

            builder.HasData(testLocationFaker.Generate(3).ToArray());
        }
    }
}
