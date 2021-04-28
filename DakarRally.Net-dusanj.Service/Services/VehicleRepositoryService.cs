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
            var Vehicle = new Vehicle()
            {
                MalfunctionType = model.MalfunctionType,
                ManufacturingDate = model.ManufacturingDate,
                Model = model.Model,
                TeamName = model.TeamName,
                Type = model.Type,
                VehicleId = model.VehicleId,
            };

            unitOfWork.Vehicles.Add(Vehicle);
            unitOfWork.SaveChanges();
        }
    }
}
