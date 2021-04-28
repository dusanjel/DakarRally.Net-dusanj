using System.ComponentModel.DataAnnotations.Schema;

namespace DakarRally.Net_dusanj.Domain.Entity
{
    [Table("Trucks")]
    public class Truck : Vehicle
    {
        public const int MaxSpeed = 140;

        public const int RepairmentDuration = 7;

        public const int MalfunctionProbabilityLight = 6;

        public const int MalfunctionProbabilityHeavy = 4;
    }
}
