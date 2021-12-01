using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thynk.Covid19Pcr.Application.RandomData;
using Thynk.Covid19Pcr.Domain.Entities;

namespace Thynk.Covid19Pcr.Infrastructure.Configurations
{
    public class TestLabConfiguration : IEntityTypeConfiguration<TestLabs>
    {
        readonly TestLabFaker testLabFaker = new();

        public void Configure(EntityTypeBuilder<TestLabs> builder)
        {
            builder.Property(p => p.LabName).HasMaxLength(100);
            builder.Property(p => p.CreatedBy).HasMaxLength(100);
            builder.Property(p => p.LastModifiedBy).HasMaxLength(100);

            builder.HasIndex(x => new { x.LabName });

            builder.HasData(testLabFaker.Generate(11).ToArray());
        }
    }
}
