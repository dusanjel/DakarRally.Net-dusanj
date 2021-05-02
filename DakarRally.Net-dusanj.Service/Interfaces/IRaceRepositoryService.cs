using DakarRally.Net_dusanj.Service.Dto;
using System;

namespace DakarRally.Net_dusanj.Service.Interfaces
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
