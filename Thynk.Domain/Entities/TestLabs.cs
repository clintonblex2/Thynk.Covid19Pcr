using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Thynk.Covid19Pcr.Domain.Entities
{
    public class TestLabs : BaseEntity
    {
        public string LabName { get; set; }
        public bool IsActive { get; set; }
        public long TestLocationId { get; set; }
        public TestLocations TestLocation { get; set; }
        public ICollection<VaccineTypes> Vaccines { get; set; } = new Collection<VaccineTypes>();
        public ICollection<AvailableTestDays> AvailableDays { get; set; } = new Collection<AvailableTestDays>();
    }
}
