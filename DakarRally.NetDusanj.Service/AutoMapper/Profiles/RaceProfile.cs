using AutoMapper;
using DakarRally.NetDusanj.Domain.Entity;
using DakarRally.NetDusanj.Service.Dto;

namespace DakarRally.NetDusanj.Service.AutoMapper.Profiles
{
    public class RaceProfile : Profile
    {
        public RaceProfile()
        {
            CreateMap<RaceDto, Race>()
                .ForMember(dest => dest.Vehicle, opts => opts.Ignore());
                //.ForMember(dest => dest.Vehicle, opts => opts.MapFrom(src => src.Vehicle));
        }
    }
}
