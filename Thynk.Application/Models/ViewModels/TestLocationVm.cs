using System.Collections.Generic;
using Thynk.Covid19Pcr.Application.Models.ViewModels;

namespace Thynk.Covid19Pcr.Application.DTOs.Response
{
    public class TestLocationVm
    {
        public string Location { get; set; }
        public IEnumerable<PatientLabVm> Labs { get; set; }
    }
}
