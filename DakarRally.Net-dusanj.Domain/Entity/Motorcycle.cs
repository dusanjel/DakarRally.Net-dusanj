using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakarRally.Net_dusanj.Domain.Entity
{
    public class Motorcycle : Vehicle
    {
        public const int MaxSpeedCross = 85;

        public const int MaxSpeedSport = 130;

        public const int RepairmentDuration = 3;

        public const int MalfunctionProbabilitySportLight = 18;

        public const int MalfunctionProbabilitySportHeavy = 10;

        public const int MalfunctionProbabilityCrossLight = 3;

        public const int MalfunctionProbabilityCrossHeavy = 2;
    }
}
