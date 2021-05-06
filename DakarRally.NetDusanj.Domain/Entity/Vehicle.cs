using DakarRally.NetDusanj.Common.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DakarRally.NetDusanj.Domain.Entity
{
    [Table("Vehicles")]
    public class Vehicle
    {
        public int VehicleId { get; set; }

        public int RaceId { get; set; }

        public string TeamName { get; set; }

        public string Model { get; set; }

        public DateTime ManufacturingDate { get; set; }

        public MalfunctionTypeEnum MalfunctionType { get; set; }

        public decimal Distance { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool Winner { get; set; }

        public bool Finished { get; set; }

        public VehicleTypeEnum VehicleType { get; set; }

        public CarTypeEnum CarType { get; set; }

        public MotorcycleTypeEnum MotorcycleType { get; set; }
    }
}
