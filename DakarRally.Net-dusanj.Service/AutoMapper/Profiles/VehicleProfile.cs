using AutoMapper;
using DakarRally.Net_dusanj.Domain.Entity;
using DakarRally.Net_dusanj.Service.Dto;

namespace DakarRally.Net_dusanj.Service.AutoMapper.Profiles
{
    public class VehicleProfile : Profile
    {
        public VehicleProfile()
        {
            CreateMap<Vehicle, VehicleDto>();

            CreateMap<VehicleDto, Vehicle>()
                .ForMember(dest => dest.MalfunctionType, opts => opts.Ignore())
                .ForMember(dest => dest.Winner, opts => opts.Ignore())
                .ForMember(dest => dest.Finished, opts => opts.Ignore())
                .ForMember(dest => dest.StartTime, opts => opts.Ignore())
                .ForMember(dest => dest.EndTime, opts => opts.Ignore())
                .ForMember(dest => dest.Distance, opts => opts.Ignore());

            CreateMap<VehicleDto, Car>()
                .ForMember(dest => dest.MalfunctionType, opts => opts.Ignore())
                .ForMember(dest => dest.Winner, opts => opts.Ignore())
                .ForMember(dest => dest.Finished, opts => opts.Ignore())
                .ForMember(dest => dest.StartTime, opts => opts.Ignore())
                .ForMember(dest => dest.EndTime, opts => opts.Ignore())
                .ForMember(dest => dest.Distance, opts => opts.Ignore());

            CreateMap<VehicleDto, Truck>()
                .ForMember(dest => dest.MalfunctionType, opts => opts.Ignore())
                .ForMember(dest => dest.Winner, opts => opts.Ignore())
                .ForMember(dest => dest.Finished, opts => opts.Ignore())
                .ForMember(dest => dest.StartTime, opts => opts.Ignore())
                .ForMember(dest => dest.EndTime, opts => opts.Ignore())
                .ForMember(dest => dest.Distance, opts => opts.Ignore());

            CreateMap<VehicleDto, Motorcycle>()
                .ForMember(dest => dest.MalfunctionType, opts => opts.Ignore())
                .ForMember(dest => dest.Winner, opts => opts.Ignore())
                .ForMember(dest => dest.Finished, opts => opts.Ignore())
                .ForMember(dest => dest.StartTime, opts => opts.Ignore())
                .ForMember(dest => dest.EndTime, opts => opts.Ignore())
                .ForMember(dest => dest.Distance, opts => opts.Ignore());
        }
    }
}
