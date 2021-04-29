using DakarRally.Net_dusanj.Common.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace DakarRally.Net_dusanj.Domain.Entity
{
    [Table("Cars")]
    public class Car : Vehicle
    {
        public const int MaxSpeedSport = 140;

        public const int MaxSpeedTerrain = 100;

        public const int RepairmentDuration = 5;

        public const int MalfunctionProbabilitySportLight = 12;

        public const int MalfunctionProbabilitySportHeavy = 2;

        public const int MalfunctionProbabilityTerrainLight = 3;

        public const int MalfunctionProbabilityTerrainHeavy = 1;

        public CarTypeEnum CarType { get; set; }
    }
}
