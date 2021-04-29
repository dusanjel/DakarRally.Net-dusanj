using DakarRally.Net_dusanj.Domain.Entity;
using DakarRally.Net_dusanj.Domain.Interfaces;

namespace DakarRally.Net_dusanj.Domain.Repositories
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
