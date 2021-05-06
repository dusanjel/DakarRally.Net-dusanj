using DakarRally.NetDusanj.Common.Enum;
using DakarRally.NetDusanj.Service.Dto;
using System;
using System.Collections.Generic;

namespace DakarRally.NetDusanj.Service.Interfaces
{
    public interface IVehicleRepositoryService
    {
        void SaveVehicle(VehicleDto model);
        VehicleDto GetVehicleById(int id);
        void UpdateVehicle(VehicleDto model);
        void RemoveById(int id);
        List<VehicleDto> GetAllVehiclesLeaderboard();
        List<VehicleDto> GetSpecificVehiclesLeaderboard(VehicleTypeEnum type);
        List<VehicleDto> GetVehicleByParameter(string teamName, string model, DateTime ManufacturingDate, decimal distance);
    }
}
