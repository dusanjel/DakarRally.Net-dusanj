using DakarRally.Net_dusanj.Service.Dto;

namespace DakarRally.Net_dusanj.Service.Interfaces
{
    public interface IVehicleRepositoryService
    {
        void SaveVehicle(VehicleDto model);
        VehicleDto getVehicleById(int id);
        void UpdateVehicle(VehicleDto model);
    }
}
