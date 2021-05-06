using DakarRally.NetDusanj.Domain.Entity;
using DakarRally.NetDusanj.Domain.Interfaces;

namespace DakarRally.NetDusanj.Domain.Repositories
{
    class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(DakarRallyDBContext context) : base(context)
        {
        }

        public DakarRallyDBContext DakarRallyDBContext
        {
            get { return Context as DakarRallyDBContext; }
        }
    }
}
