using AutoMapper;
using AutoMapperExample.WebApi.InputModels;
using AutoMapperExample.WebApi.Models;
using AutoMapperExample.WebApi.ViewModels;

namespace AutoMapperExample.WebApi.Config
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SectorInputModel,Sector>();
            CreateMap<EmployeeInputModel, Employee>();

            CreateMap<Sector, SectorViewModel>();
            CreateMap<Employee, EmployeeViewModel>()
            .ForMember(dist => dist.Name, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
        }
    }
}