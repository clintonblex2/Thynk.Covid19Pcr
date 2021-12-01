using Thynk.Covid19Pcr.Domain.Entities;

namespace Thynk.Covid19Pcr.Application.Models.ViewModels
{
    public class VaccineTypePatienceVm
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int RecommendedAge { get; set; }

        public static VaccineTypePatienceVm ToVaccineTypeDTOMap(VaccineTypes vaccineType)
        {
            return new VaccineTypePatienceVm()
            {
                Id = vaccineType.Id,
                Name = vaccineType.Name,
                RecommendedAge = vaccineType.RecommendedAge
            };
        }
    }
}
