using DakarRally.Net_dusanj.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakarRally.Net_dusanj.Service.Interfaces
{
    public interface IRaceRepositoryService
    {
        void SaveRace(RaceDto model);
    }
}
