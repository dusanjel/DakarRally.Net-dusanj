using DakarRally.Net_dusanj.Common.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace DakarRally.Net_dusanj.Domain.Entity
{
    [Table("Cars")]
    public class Car : Vehicle
    {
        public const decimal MaxSpeedSport = 140;

        public const decimal MaxSpeedTerrain = 100;

        public const decimal RepairmentDuration = 5;

        public const decimal MalfunctionProbabilitySportLight = 12;

        public const decimal MalfunctionProbabilitySportHeavy = 2;

        public const decimal MalfunctionProbabilityTerrainLight = 3;

        public const decimal MalfunctionProbabilityTerrainHeavy = 1;

        public CarTypeEnum CarType { get; set; }
    }
}
