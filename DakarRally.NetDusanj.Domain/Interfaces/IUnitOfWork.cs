using System;

namespace DakarRally.NetDusanj.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IVehicleRepository Vehicles { get; }
        IRaceRepository Races { get; }
        int SaveChanges();
    }
}
