using System.ComponentModel.DataAnnotations.Schema;

namespace DakarRally.Net_dusanj.Domain.Entity
{
    [Table("Motorcycles")]
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
