using System;
using System.Collections.Generic;

namespace DakarRally.Net_dusanj.Domain.Entity
{
    public class Race
    {
        public const decimal Distance = 10000;

        public int RaceId { get; set; }

        public DateTime Year { get; set; }

        public int RaceStatus { get; set; }

        public int VehicleId { get; set; }

        public virtual ICollection<Vehicle> Vehicle { get; set; }
        
    }
}
