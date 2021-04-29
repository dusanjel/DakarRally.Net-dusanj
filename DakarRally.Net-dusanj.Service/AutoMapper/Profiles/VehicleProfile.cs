using AutoMapper;
using DakarRally.Net_dusanj.Domain.Entity;
using DakarRally.Net_dusanj.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakarRally.Net_dusanj.Service.AutoMapper.Profiles
{
    public class VehicleProfile : Profile
    {
        public VehicleProfile()
        {
            CreateMap<Vehicle, VehicleDto>()
                .ForMember(dest => dest.CarType, opts => opts.Ignore())
                .ForMember(dest => dest.MotorcycleType, opts => opts.Ignore())
                .ForMember(dest => dest.VehicleType, opts => opts.Ignore());

            CreateMap<VehicleDto, Vehicle>();

            CreateMap<VehicleDto, Car>();

            CreateMap<VehicleDto, Truck>();

            CreateMap<VehicleDto, Motorcycle>();
        }
    }
}
