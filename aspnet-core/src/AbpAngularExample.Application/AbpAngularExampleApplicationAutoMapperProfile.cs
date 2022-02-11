using AbpAngularExample.DTOs.Brands;
using AbpAngularExample.DTOs.Cars;
using AbpAngularExample.DTOs.Models;
using AutoMapper;

namespace AbpAngularExample;

public class AbpAngularExampleApplicationAutoMapperProfile : Profile
{
    public AbpAngularExampleApplicationAutoMapperProfile()
    {
        CreateMap<AbpAngularExample.Entities.Brand, BrandDto>().ReverseMap();
        CreateMap<AbpAngularExample.Entities.Brand, BrandCreateDto>().ReverseMap();
        CreateMap<AbpAngularExample.Entities.Brand, BrandUpdateDto>().ReverseMap();

        CreateMap<AbpAngularExample.Entities.Model, ModelDto>().ReverseMap();
        CreateMap<AbpAngularExample.Entities.Model, ModelCreateDto>().ReverseMap();
        CreateMap<AbpAngularExample.Entities.Model, ModelUpdateDto>().ReverseMap();

        CreateMap<AbpAngularExample.Entities.Car, CarDto>().ReverseMap();
        CreateMap<AbpAngularExample.Entities.Car, CarCreateDto>().ReverseMap();
        CreateMap<AbpAngularExample.Entities.Car, CarUpdateDto>().ReverseMap();
    }
}
