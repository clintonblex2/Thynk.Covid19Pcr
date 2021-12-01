using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Thynk.Covid19Pcr.Domain.Entities
{
    public class TestLocations : BaseEntity
    {
        public string City { get; set; }
        public string Country { get; set; }
        public bool IsOperational { get; set; }
        public ICollection<TestLabs> LabsInLocation { get; set; } = new Collection<TestLabs>();
    }
}
