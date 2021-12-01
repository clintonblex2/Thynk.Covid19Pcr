namespace Thynk.Covid19Pcr.Application.Models.Request
{
    public class AddVaccineTypeRequest
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool IsApproved { get; set; }
        public int RecommendedAge { get; set; }
        public int TotalSupplied { get; set; }
    }
}
