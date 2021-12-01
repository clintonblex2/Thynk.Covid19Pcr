using System;

namespace Thynk.Covid19Pcr.Application.Models.ViewModels
{
    public class AvailableTestDaysVm
    {
        public long Id { get; set; }
        public int OpenSlots { get; set; }
        public DateTime AvailableDate { get; set; }
    }
}
