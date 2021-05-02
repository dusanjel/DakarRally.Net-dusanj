using DakarRally.Net_dusanj.Common.Enum;
using DakarRally.Net_dusanj.Service.Dto;
using System;
using System.Collections.Generic;

namespace DakarRally.Net_dusanj.Service.Interfaces
{
    public interface IVehicleRepositoryService
    {
        void SaveVehicle(VehicleDto model);
        VehicleDto getVehicleById(int id);
        void UpdateVehicle(VehicleDto model);
        void removeById(int id);
        List<VehicleDto> getAllVehiclesLeaderboard();
        List<VehicleDto> getSpecificVehiclesLeaderboard(VehicleTypeEnum type);
        List<VehicleDto> getVehicleByParameter(string teamName, string model, DateTime ManufacturingDate, decimal distance);
    }
}
