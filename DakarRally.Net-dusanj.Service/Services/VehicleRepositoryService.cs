using DakarRally.Net_dusanj.Domain.Interfaces;
using DakarRally.Net_dusanj.Service.Dto;
using DakarRally.Net_dusanj.Service.Interfaces;
using DakarRally.Net_dusanj.Domain.Entity;
using DakarRally.Net_dusanj.Common.Enum;
using AutoMapper;

namespace DakarRally.Net_dusanj.Service.Services
{
    public class VehicleRepositoryService : IVehicleRepositoryService
    {
        private IMapper _mapper;
        private readonly IUnitOfWork unitOfWork;

        public VehicleRepositoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void SaveVehicle(VehicleDto model)
        {
            Vehicle vehicle;

            switch (model.VehicleType)
            {
                case VehicleTypeEnum.Car:
                    vehicle = _mapper.Map<Car>(model);
                    break;
                case VehicleTypeEnum.Motorcycle:
                    vehicle = _mapper.Map<Motorcycle>(model);
                    break;
                default:
                    vehicle = _mapper.Map<Truck>(model);
                    break;
            }

            unitOfWork.Vehicles.Add(vehicle);
            unitOfWork.SaveChanges();
        }

        public void UpdateVehicle(VehicleDto model) 
        {
            var result = unitOfWork.Vehicles.Get(model.VehicleId);

            result.ManufacturingDate = model.ManufacturingDate;
            result.Model = model.Model;
            result.TeamName = model.TeamName;

            unitOfWork.Vehicles.Edit(result);
            unitOfWork.SaveChanges();
        }


        public VehicleDto getVehicleById(int id) 
        {
            var result = unitOfWork.Vehicles.Get(id);

            var vehicle = _mapper.Map<VehicleDto>(result);

            return vehicle;
        }
    }
}
