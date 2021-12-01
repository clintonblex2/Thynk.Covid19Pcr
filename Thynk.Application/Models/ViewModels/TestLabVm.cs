using System.Collections.Generic;
using Thynk.Covid19Pcr.Application.Models.ViewModels;

namespace Thynk.Covid19Pcr.Application.Models.Response
{
    public class TestLabVm
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<AvailableTestDaysVm> AvailableTestDays { get; set; }

    }
}
