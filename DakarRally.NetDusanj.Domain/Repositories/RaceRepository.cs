using DakarRally.NetDusanj.Domain.Entity;
using DakarRally.NetDusanj.Domain.Interfaces;

namespace DakarRally.NetDusanj.Domain.Repositories
{
    class RaceRepository : GenericRepository<Race>, IRaceRepository
    {
        public RaceRepository(DakarRallyDBContext context) : base(context)
        {
        }

        public DakarRallyDBContext DakarRallyDBContext
        {
            get { return Context as DakarRallyDBContext; }
        }
    }
}
