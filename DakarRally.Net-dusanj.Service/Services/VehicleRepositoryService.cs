using DakarRally.Net_dusanj.Domain.Interfaces;
using DakarRally.Net_dusanj.Service.Dto;
using DakarRally.Net_dusanj.Service.Interfaces;
using DakarRally.Net_dusanj.Domain.Entity;
using DakarRally.Net_dusanj.Common.Enum;

namespace DakarRally.Net_dusanj.Service.Services
{
    public class VehicleRepositoryService : IVehicleRepositoryService
    {
        private readonly IUnitOfWork unitOfWork;

        public VehicleRepositoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void SaveVehicle(VehicleDto model)
        {
            Vehicle vehicle;

            switch (model.VehicleType)
            {
                case VehicleTypeEnum.Car:
                    vehicle = new Car()
                    {
                        MalfunctionType = model.MalfunctionType,
                        ManufacturingDate = model.ManufacturingDate,
                        Model = model.Model,
                        TeamName = model.TeamName,
                        CarType = model.CarType,                        
                    };
                    break;
                case VehicleTypeEnum.Motorcycle:
                    vehicle = new Motorcycle()
                    {
                        MalfunctionType = model.MalfunctionType,
                        ManufacturingDate = model.ManufacturingDate,
                        Model = model.Model,
                        TeamName = model.TeamName,
                        MotorcycleType = model.MotorcycleType,
                    };
                    break;
                default:
                    vehicle = new Truck()
                    {
                        MalfunctionType = model.MalfunctionType,
                        ManufacturingDate = model.ManufacturingDate,
                        Model = model.Model,
                        TeamName = model.TeamName,
                    };
                    break;
            }

            unitOfWork.Vehicles.Add(vehicle);
            unitOfWork.SaveChanges();
        }

        public VehicleDto getVehicleById(int id) 
        {
            var result = unitOfWork.Vehicles.Get(id);

            var vehicle = new VehicleDto()
            {
                VehicleId = result.VehicleId,
                MalfunctionType = result.MalfunctionType,
                ManufacturingDate = result.ManufacturingDate,
                Model = result.Model,
                TeamName = result.TeamName,
            };

            return vehicle;
        }
    }
}
