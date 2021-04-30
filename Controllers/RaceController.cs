using DakarRally.Net_dusanj.Service.Dto;
using DakarRally.Net_dusanj.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DakarRally.Net_dusanj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RaceController : ControllerBase
    {
        private readonly ILogger<VehicleController> _logger;
        private readonly IRaceRepositoryService raceRepositoryService;

        public RaceController(ILogger<VehicleController> logger, IRaceRepositoryService raceRepositoryService)
        {
            _logger = logger;
            this.raceRepositoryService = raceRepositoryService;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateRace(int Year)
        {
            raceRepositoryService.SaveRaceByYear(new DateTime(Year,1,1));

            return Ok();
        }
    }
}
