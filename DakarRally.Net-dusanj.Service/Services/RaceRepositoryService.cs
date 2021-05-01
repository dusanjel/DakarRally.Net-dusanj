using AutoMapper;
using DakarRally.Net_dusanj.Common.Enum;
using DakarRally.Net_dusanj.Domain.Entity;
using DakarRally.Net_dusanj.Domain.Interfaces;
using DakarRally.Net_dusanj.Service.Dto;
using DakarRally.Net_dusanj.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void SaveRaceByYear(DateTime Year)
        {
            Race race = new Race()
            {
                Year = Year,
            };

            unitOfWork.Races.Add(race);
            unitOfWork.SaveChanges();
        }

        public void UpdateRace(VehicleDto model)
        {
            var race = unitOfWork.Races.Get(model.RaceId);

            if (race != null)
            {
                switch (model.VehicleType)
                {
                    case VehicleTypeEnum.Car:
                        race.Vehicle = new List<Vehicle>() { _mapper.Map<Car>(model) };
                        break;
                    case VehicleTypeEnum.Motorcycle:
                        race.Vehicle = new List<Vehicle>() { _mapper.Map<Motorcycle>(model) };
                        break;
                    default:
                        race.Vehicle = new List<Vehicle>() { _mapper.Map<Truck>(model) };
                        break;
                }

                unitOfWork.Races.Edit(race);
                unitOfWork.SaveChanges();
            }
        }

        public void StartRace(int RaceId)
        {
            var race = unitOfWork.Races.Get(RaceId);

            if (race != null)
            {
                race.RaceStatus = RaceStatusEnum.Running;

                unitOfWork.Races.Edit(race);
                unitOfWork.SaveChanges();
            }
        }

        public void ManageRace()
        {
            var allRaces = unitOfWork.Races.GetAll();

            var allVehicles = unitOfWork.Vehicles.GetAll();

            var query = allRaces
               .Join(allVehicles,
                  race => race.RaceId,
                  veh => veh.RaceId,
                  (race, veh) => new { Race = race, Veh = veh })
               .Where(raceAndveh => raceAndveh.Race.RaceStatus == RaceStatusEnum.Running);

            var vehicles = query.AsEnumerable()
                .GroupBy(x => x.Veh).Select(x => _mapper.Map<Vehicle>(x.Key)).ToList();

            // TODO: improve calc, add finish race, add start time and end time, add malfunction probability
            
            var seconds = 3600 * 10;

            foreach (var vehicle in vehicles)
            {
                switch (vehicle.VehicleType)
                {
                    case VehicleTypeEnum.Car:
                        if (vehicle.CarType == CarTypeEnum.Sport)
                            vehicle.Distance += Car.MaxSpeedSport / seconds;
                        else
                            vehicle.Distance += Car.MaxSpeedTerrain / seconds;
                        break;
                    case VehicleTypeEnum.Motorcycle:
                        if (vehicle.MotorcycleType == MotorcycleTypeEnum.Sport)
                            vehicle.Distance += Motorcycle.MaxSpeedSport / seconds;
                        else
                            vehicle.Distance += Motorcycle.MaxSpeedCross / seconds;
                        break;
                    default:
                        vehicle.Distance += Truck.MaxSpeed / seconds;
                        break;
                }

                if (vehicle.Distance == Race.Distance)
                {
                    vehicle.Winner = true;
                }

                unitOfWork.Vehicles.Edit(vehicle);
                unitOfWork.SaveChanges();
            }
        }
    }
}
