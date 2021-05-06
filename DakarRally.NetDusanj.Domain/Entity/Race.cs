using DakarRally.NetDusanj.Common.Enum;
using System;
using System.Collections.Generic;

namespace DakarRally.NetDusanj.Domain.Entity
{
    public class Race
    {
        public const decimal Distance = 10000;

        public int RaceId { get; set; }

        public DateTime Year { get; set; }

        public RaceStatusEnum RaceStatus { get; set; }

        public virtual ICollection<Vehicle> Vehicle { get; set; }
        
    }
}
