using System.Collections.Generic;
using Thynk.Covid19Pcr.Application.Models.Response;

namespace Thynk.Covid19Pcr.Application.DTOs.Response
{
    public class LocationsWithLabsVm
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<TestLabVm> AvailableTestLabs { get; set; }
    }
}
