using System;

namespace Thynk.Covid19Pcr.Application.Models.ViewModels
{
    public class TestDaysWithLabLocationVm
    {
        public long Id { get; set; }
        public int OpenSlots { get; set; }
        public string TestLab { get; set; }
        public string Location { get; set; }
        public DateTime AvailableDate { get; set; }
    }
}
