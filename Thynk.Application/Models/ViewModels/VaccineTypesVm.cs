namespace Thynk.Covid19Pcr.Application.Models.ViewModels
{
    public class VaccineTypesVm
    {
        public long Id { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsApproved { get; set; }
        public int RecommendedAge { get; set; }
        public int TotalSupplied { get; set; }

    }
}
