using DakarRally.Net_dusanj.Domain.Entity;
using DakarRally.Net_dusanj.Domain.Interfaces;

namespace DakarRally.Net_dusanj.Domain.Repositories
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
