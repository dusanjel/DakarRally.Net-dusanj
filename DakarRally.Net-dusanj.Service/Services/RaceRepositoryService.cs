﻿using AutoMapper;
using DakarRally.Net_dusanj.Common.Enum;
using DakarRally.Net_dusanj.Domain.Entity;
using DakarRally.Net_dusanj.Domain.Interfaces;
using DakarRally.Net_dusanj.Service.Dto;
using DakarRally.Net_dusanj.Service.Interfaces;
using System.Collections.Generic;

namespace DakarRally.Net_dusanj.Service.Services
{
    public class RaceRepositoryService : IRaceRepositoryService
    {
        private IMapper _mapper;
        private readonly IUnitOfWork unitOfWork;

        public RaceRepositoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void SaveRace(RaceDto model)
        {
            Race race;

            switch (model.Vehicle.VehicleType)
            {
                case VehicleTypeEnum.Car:
                    race = _mapper.Map<Race>(model);
                    race.Vehicle = new List<Vehicle>() { _mapper.Map<Car>(model.Vehicle) };
                    break;
                case VehicleTypeEnum.Motorcycle:
                    race = _mapper.Map<Race>(model);
                    race.Vehicle = new List<Vehicle>() { _mapper.Map<Motorcycle>(model.Vehicle) };
                    break;
                default:
                    race = _mapper.Map<Race>(model);
                    race.Vehicle = new List<Vehicle>() { _mapper.Map<Truck>(model.Vehicle) };
                    break;
            }

            unitOfWork.Races.Add(race);
            unitOfWork.SaveChanges();
        }
    }
}