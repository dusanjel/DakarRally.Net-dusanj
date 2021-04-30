﻿using System;

namespace DakarRally.Net_dusanj.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IVehicleRepository Vehicles { get; }
        IRaceRepository Races { get; }
        int SaveChanges();
    }
}
