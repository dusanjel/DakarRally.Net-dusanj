using DakarRally.Net_dusanj.Common.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace DakarRally.Net_dusanj.Domain.Entity
{
    [Table("Motorcycles")]
    public class Motorcycle : Vehicle
    {
        public const decimal MaxSpeedCross = 85;

        public const decimal MaxSpeedSport = 130;

        public const decimal RepairmentDuration = 3;

        public const int MalfunctionProbabilitySportLight = 18;

        public const int MalfunctionProbabilitySportHeavy = 10;

        public const int MalfunctionProbabilityCrossLight = 3;

        public const int MalfunctionProbabilityCrossHeavy = 2;
    }
}
