using DakarRally.Net_dusanj.Domain.Interfaces;
using DakarRally.Net_dusanj.Service.Dto;
using DakarRally.Net_dusanj.Service.Interfaces;
using DakarRally.Net_dusanj.Domain.Entity;

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
            var vehicle = new Vehicle()
            {
                MalfunctionType = model.MalfunctionType,
                ManufacturingDate = model.ManufacturingDate,
                Model = model.Model,
                TeamName = model.TeamName,
                Type = model.Type,
            };

            unitOfWork.Vehicles.Add(vehicle);
            unitOfWork.SaveChanges();
        }

        public VehicleDto getVehicleById(int id) 
        {
            var result = unitOfWork.Vehicles.Get(id);

            var vehicle = new VehicleDto()
            {
                MalfunctionType = result.MalfunctionType,
                ManufacturingDate = result.ManufacturingDate,
                Model = result.Model,
                TeamName = result.TeamName,
                Type = result.Type,
            };

            return vehicle;
        }
    }
}
