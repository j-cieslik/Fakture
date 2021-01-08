using AutoMapper;
using Dtos;
using Models;

namespace Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Fakture, FactureToReturnDto>()
                .ForMember(d => d.Name, o => o.MapFrom(s => s.FaktureStatus.Name));

            CreateMap<FactureToReturnDto, Fakture>();

        }


    }
}