using AutoMapper;
using DakarRally.Net_dusanj.Domain.Entity;
using DakarRally.Net_dusanj.Service.Dto;

namespace DakarRally.Net_dusanj.Service.AutoMapper.Profiles
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
