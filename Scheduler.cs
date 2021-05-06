using DakarRally.NetDusanj.Interfaces;
using DakarRally.NetDusanj.Service.Interfaces;
using Hangfire;
using Microsoft.Extensions.Logging;

namespace DakarRally.NetDusanj
{
    public class Scheduler : IScheduler
    {
        private readonly ILogger<Scheduler> _logger;
        private readonly IRaceRepositoryService raceRepositoryService;
        private readonly IVehicleRepositoryService vehicleRepositoryService;

        public Scheduler(ILogger<Scheduler> logger, IRaceRepositoryService raceRepositoryService, IVehicleRepositoryService vehicleRepositoryService)
        {
            _logger = logger;
            this.raceRepositoryService = raceRepositoryService;
            this.vehicleRepositoryService = vehicleRepositoryService;
        }

        public void Schedule()
        {
            RecurringJob.AddOrUpdate(() => raceRepositoryService.ManageRace(), "*/10 * * * * *");
        }
    }
}
