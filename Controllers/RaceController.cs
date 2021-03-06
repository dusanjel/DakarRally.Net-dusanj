using DakarRally.NetDusanj.Service.Dto;
using DakarRally.NetDusanj.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace DakarRally.NetDusanj.Controllers
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
            raceRepositoryService.SaveRaceByYear(new DateTime(Year,month:1,day:1));

            return Ok();
        }

        [HttpPost]
        [Route("addvehicle")]
        public IActionResult AddVehicle(VehicleDto vehicle)
        {
            raceRepositoryService.UpdateRace(vehicle);

            return Ok();
        }

        [HttpPost]
        [Route("start")]
        public IActionResult Start(int raceId)
        {
            raceRepositoryService.StartRace(raceId);

            return Ok();
        }

        [HttpGet]
        [Route("status")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetStatus(int id)
        {
            return Ok(raceRepositoryService.GetRaceStatus(id));
        }
    }
}
