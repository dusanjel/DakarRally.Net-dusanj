using DakarRally.Net_dusanj.Common.Enum;
using System;
using System.Collections.Generic;

namespace DakarRally.Net_dusanj.Service.Dto
{
    public class RaceDto
    {
        public decimal Distance { get; set; }

        public int RaceId { get; set; }

        public DateTime Year { get; set; }

        public RaceStatusEnum RaceStatus { get; set; }

        public int VehicleId { get; set; }

        public virtual VehicleDto Vehicle { get; set; }
    }
}
