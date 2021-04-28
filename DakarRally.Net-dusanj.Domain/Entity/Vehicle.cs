using DakarRally.Net_dusanj.Common.Enum;
using System;

namespace DakarRally.Net_dusanj.Domain.Entity
{
    public abstract class Vehicle
    {
        public Guid Id { get; set; }

        public string TeamName { get; set; }

        public string Model { get; set; }

        public DateTime ManufacturingDate { get; set; }

        public VehicleTypeEnum Type { get; set; }

        public MalfunctionTypeEnum MalfunctionType { get; set; }
    }
}
