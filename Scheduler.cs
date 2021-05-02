using DakarRally.Net_dusanj.Interfaces;
using DakarRally.Net_dusanj.Service.Interfaces;
using Hangfire;
using Microsoft.Extensions.Logging;

namespace DakarRally.Net_dusanj
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
