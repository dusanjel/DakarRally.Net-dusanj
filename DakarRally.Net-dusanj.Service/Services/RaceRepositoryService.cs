using AutoMapper;
using DakarRally.Net_dusanj.Common.Enum;
using DakarRally.Net_dusanj.Common.Help;
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
                .GroupBy(x => x.Veh).Select(x => _mapper.Map<Vehicle>(x.Key))
                .Where(x => x.MalfunctionType != MalfunctionTypeEnum.Heavie).ToList();

            // TODO: Improve calculation, add finish race, add start time and end time
            
            var seconds = 3600 * 10;

            foreach (var vehicle in vehicles)
            {
                switch (vehicle.VehicleType)
                {
                    case VehicleTypeEnum.Car:
                        if (vehicle.CarType == CarTypeEnum.Sport) 
                        {
                            vehicle.Distance += (Car.MaxSpeedSport / seconds);

                            if ((vehicle.Distance % Car.MaxSpeedSport) == 0)
                            {
                                vehicle.MalfunctionType = Malfunction.Probability
                                (
                                    Car.MalfunctionProbabilitySportLight,
                                    Car.MalfunctionProbabilitySportHeavy
                                );

                                if (vehicle.MalfunctionType == MalfunctionTypeEnum.Light)
                                {
                                    vehicle.Distance -= (Car.MaxSpeedSport * Car.RepairmentDuration);
                                }
                            }
                        } 
                        else
                        {
                            vehicle.Distance += (Car.MaxSpeedTerrain / seconds);
                           
                            if ((vehicle.Distance % Car.MaxSpeedTerrain) == 0)
                            {
                                vehicle.MalfunctionType = Malfunction.Probability
                                (
                                    Car.MalfunctionProbabilityTerrainLight,
                                    Car.MalfunctionProbabilityTerrainHeavy
                                );
                                if (vehicle.MalfunctionType == MalfunctionTypeEnum.Light)
                                {
                                    vehicle.Distance -= (Car.MaxSpeedTerrain * Car.RepairmentDuration);
                                }
                            }
                        }
                        break;
                    case VehicleTypeEnum.Motorcycle:
                        if (vehicle.MotorcycleType == MotorcycleTypeEnum.Sport)
                        {
                            vehicle.Distance += (Motorcycle.MaxSpeedSport / seconds);
                           
                            if ((vehicle.Distance % Motorcycle.MaxSpeedSport) == 0)
                            {
                                vehicle.MalfunctionType = Malfunction.Probability
                                (
                                    Motorcycle.MalfunctionProbabilitySportLight,
                                    Motorcycle.MalfunctionProbabilitySportHeavy
                                );
                                if (vehicle.MalfunctionType == MalfunctionTypeEnum.Light)
                                {
                                    vehicle.Distance -= (Motorcycle.MaxSpeedSport * Motorcycle.RepairmentDuration);
                                }
                            }
                        } 
                        else
                        {
                            vehicle.Distance += (Motorcycle.MaxSpeedCross / seconds);
                           
                            if ((vehicle.Distance % Motorcycle.MaxSpeedCross) == 0)
                            {
                                vehicle.MalfunctionType = Malfunction.Probability
                                (
                                    Motorcycle.MalfunctionProbabilityCrossLight,
                                    Motorcycle.MalfunctionProbabilityCrossHeavy
                                );
                                if (vehicle.MalfunctionType == MalfunctionTypeEnum.Light)
                                {
                                    vehicle.Distance -= (Motorcycle.MaxSpeedCross * Motorcycle.RepairmentDuration);
                                }
                            }
                        }
                            
                        break;
                    default:
                        vehicle.Distance += (Truck.MaxSpeed / seconds);
                        
                        if ((vehicle.Distance % Truck.MaxSpeed) == 0)
                        {
                            vehicle.MalfunctionType = Malfunction.Probability
                            (
                                Truck.MalfunctionProbabilityLight,
                                Truck.MalfunctionProbabilityHeavy
                            );
                            if (vehicle.MalfunctionType == MalfunctionTypeEnum.Light)
                            {
                                vehicle.Distance -= (Truck.MaxSpeed * Truck.RepairmentDuration);
                            }
                        }
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
