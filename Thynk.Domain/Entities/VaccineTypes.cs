namespace Thynk.Covid19Pcr.Domain.Entities
{
    public class VaccineTypes : BaseEntity
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsApproved { get; set; }
        public int RecommendedAge { get; set; }
        public int TotalSupplied { get; set; }

        public static (bool, string) IsValidAge(int age, int recommendedAge)
        {
            if (age < 5) return (false, "The recommended age for Covid-19 vaccine is 5 years and older");

            if (age < recommendedAge) return (false, $"The recommended age for the selected vaccine is {recommendedAge}+");

            return (true, "Valid");
        }
    }
}
