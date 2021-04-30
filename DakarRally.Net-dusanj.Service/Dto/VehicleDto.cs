using DakarRally.Net_dusanj.Common.Enum;
using System;

namespace DakarRally.Net_dusanj.Service.Dto
{
    public class VehicleDto
    {
        public int VehicleId { get; set; }

        public int RaceId { get; set; }

        public string TeamName { get; set; }

        public string Model { get; set; }

        public DateTime ManufacturingDate { get; set; }

        public CarTypeEnum CarType { get; set; }

        public MotorcycleTypeEnum MotorcycleType { get; set; }

        public VehicleTypeEnum VehicleType { get; set; }
    }
}
