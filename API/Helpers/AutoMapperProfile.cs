using API.Entities;
using API.ViewModels;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Vehicle, VehicleViewModel>()
            .ForMember(dest => dest.Brand, opt => opt.MapFrom(src => src.Brand.Name))
            .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model.Description));

            CreateMap<Brand, BrandViewModel>()
            .ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Name));
        }
    }
}