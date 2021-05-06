using System.ComponentModel.DataAnnotations.Schema;

namespace DakarRally.NetDusanj.Domain.Entity
{
    [Table("Trucks")]
    public class Truck : Vehicle
    {
        public const decimal MaxSpeed = 140;

        public const decimal RepairmentDuration = 7;

        public const int MalfunctionProbabilityLight = 6;

        public const int MalfunctionProbabilityHeavy = 4;
    }
}
