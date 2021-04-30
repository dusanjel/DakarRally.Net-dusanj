using System.ComponentModel.DataAnnotations.Schema;

namespace DakarRally.Net_dusanj.Domain.Entity
{
    [Table("Trucks")]
    public class Truck : Vehicle
    {
        public const decimal MaxSpeed = 140;

        public const decimal RepairmentDuration = 7;

        public const decimal MalfunctionProbabilityLight = 6;

        public const decimal MalfunctionProbabilityHeavy = 4;
    }
}
