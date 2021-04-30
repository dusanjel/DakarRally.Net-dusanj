using DakarRally.Net_dusanj.Service.Dto;
using System;

namespace DakarRally.Net_dusanj.Service.Interfaces
{
    public interface IRaceRepositoryService
    {
        void SaveRace(RaceDto model);
        void SaveRaceByYear(DateTime Year);
        void UpdateRace(int RaceId, VehicleDto model);

        void StartRace(int RaceId);
    }
}
