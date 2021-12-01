using System;

namespace Thynk.Covid19Pcr.Domain.Entities
{
    public class AvailableTestDays : BaseEntity
    {
        public int OpenSlots { get; set; }
        public DateTime AvailableDate { get; set; }
        public long TestLabId { get; set; }
        public TestLabs TestLab { get; set; }

    }
}
