using DakarRally.Net_dusanj.Common.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DakarRally.Net_dusanj.Domain.Entity
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
    }
}
