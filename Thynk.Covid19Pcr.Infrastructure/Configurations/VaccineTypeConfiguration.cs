using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thynk.Covid19Pcr.Application.RandomData;
using Thynk.Covid19Pcr.Domain.Entities;

namespace Thynk.Covid19Pcr.Infrastructure.Configurations
{
    public class VaccineTypeConfiguration : IEntityTypeConfiguration<VaccineTypes>
    {
        readonly VaccineTypeFaker vaccineTypes = new();

        public void Configure(EntityTypeBuilder<VaccineTypes> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.Manufacturer).HasMaxLength(100);
            builder.Property(p => p.CreatedBy).HasMaxLength(100);
            builder.Property(p => p.LastModifiedBy).HasMaxLength(100);

            builder.HasIndex(x => new { x.Name });

            builder.HasData(vaccineTypes.Generate(3).ToArray());


        }
    }
}
