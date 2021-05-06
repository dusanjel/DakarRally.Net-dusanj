using DakarRally.NetDusanj.Service.Dto;
using System;

namespace DakarRally.NetDusanj.Service.Interfaces
{
    public interface IRaceRepositoryService
    {
        void SaveRaceByYear(DateTime Year);

        void UpdateRace(VehicleDto model);

        RaceStatusDto GetRaceStatus(int raceId);

        void StartRace(int RaceId);

        void ManageRace();
    }
}
