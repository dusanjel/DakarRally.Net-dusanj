﻿using DakarRally.Net_dusanj.Domain.Entity;
using DakarRally.Net_dusanj.Domain.Interfaces;

namespace DakarRally.Net_dusanj.Domain.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DakarRallyDBContext _context;

        public IVehicleRepository Vehicles { get; private set; }
        public IRaceRepository Races { get; private set; }

        public UnitOfWork(DakarRallyDBContext context)
        {
            _context = context;
            // TODO: Resolve DI
            Vehicles = new VehicleRepository(_context);
            Races = new RaceRepository(_context);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
