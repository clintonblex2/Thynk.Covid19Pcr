using AutoMapper;
using Thynk.Covid19Pcr.Application.DTOs.Response;
using Thynk.Covid19Pcr.Application.Models.Request;
using Thynk.Covid19Pcr.Application.Models.Response;
using Thynk.Covid19Pcr.Application.Models.ViewModels;
using Thynk.Covid19Pcr.Domain.Entities;

namespace Thynk.Covid19Pcr.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<VaccineTypesVm, VaccineTypes>().ReverseMap();

            CreateMap<Patients, BookingRequest>().ReverseMap()
                .ForMember(x => x.Gender, src => src.Ignore());

            CreateMap<AvailableTestDaysVm, AvailableTestDays>().ReverseMap();

            CreateMap<TestLabVm, TestLabs>().ReverseMap()
                .ForMember(x => x.Name, src => src.MapFrom(x => x.LabName))
                .ForMember(x => x.AvailableTestDays, src => src.MapFrom(x => x.AvailableDays));

            CreateMap<LocationsWithLabsVm, TestLocations>().ReverseMap()
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.City))
                .ForMember(x => x.AvailableTestLabs, opt => opt.MapFrom(x => x.LabsInLocation));
                
            CreateMap<AddVaccineTypeRequest, VaccineTypes>().ReverseMap();

            CreateMap<PatientLabVm, TestLabs>().ReverseMap();

            CreateMap<TestLocationVm, TestLocations>().ReverseMap()
                .ForMember(x => x.Location, src => src.MapFrom(x => x.City))
                .ForMember(x => x.Labs, src => src.MapFrom(x => x.LabsInLocation));

            CreateMap<TestBookings, TestBookingVm>()
                 .ForMember(x => x.FirstName, src => src.MapFrom(x => x.Patient.FirstName))
                 .ForMember(x => x.Email, src => src.MapFrom(x => x.Patient.Email))
                 .ForMember(x => x.LastName, src => src.MapFrom(x => x.Patient.LastName))
                 .ForMember(x => x.PhoneNumber, src => src.MapFrom(x => x.Patient.PhoneNumber))
                 .ForMember(x => x.VaccineType, src => src.MapFrom(x => x.VaccineType.Name))
                 .ForMember(x => x.TestLocation, src => src.MapFrom(x => x.AvailableTestDay.TestLab.TestLocation.City))
                 .ForMember(x => x.TestLab, src => src.MapFrom(x => x.AvailableTestDay.TestLab.LabName))
                 .ForMember(x => x.TestDate, src => src.MapFrom(x => x.AvailableTestDay.AvailableDate));

            CreateMap<TestDaysWithLabLocationVm, AvailableTestDays>().ReverseMap()
                .ForMember(x => x.TestLab, opt => opt.MapFrom(x => x.TestLab.LabName))
                .ForMember(x => x.Location, opt => opt.MapFrom(x => x.TestLab.TestLocation.City));

            CreateMap<CovidTestResultRequest, ReportRequest>().ReverseMap();
        }

    }
}
