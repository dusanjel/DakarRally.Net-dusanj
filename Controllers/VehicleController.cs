using DakarRally.Net_dusanj.Common.Enum;
using DakarRally.Net_dusanj.Service.Dto;
using DakarRally.Net_dusanj.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace DakarRally.Net_dusanj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _logger;
        private readonly IVehicleRepositoryService vehicleRepositoryService;

        public VehicleController(ILogger<VehicleController> logger, IVehicleRepositoryService vehicleRepositoryService)
        {
            _logger = logger;
            this.vehicleRepositoryService = vehicleRepositoryService;
        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update([FromBody] VehicleDto vehicle)
        {
            vehicleRepositoryService.UpdateVehicle(vehicle);

            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get(int id)
        {
            return Ok(vehicleRepositoryService.getVehicleById(id));
        }

        [HttpPost]
        [Route("remove")]
        public IActionResult Remove(int id)
        {
            vehicleRepositoryService.removeById(id);

            return Ok();
        }

        [HttpGet]
        [Route("leaderboardall")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetLeaderboardAll()
        {
            return Ok(vehicleRepositoryService.getAllVehiclesLeaderboard());
        }

        [HttpGet]
        [Route("leaderboardbytype")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetLeaderboardByType(VehicleTypeEnum type)
        {
            return Ok(vehicleRepositoryService.getSpecificVehiclesLeaderboard(type));
        }

        [HttpGet]
        [Route("leaderboardbyparameter")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetLeaderboardParameter(string teamName, string model, DateTime ManufacturingDate, decimal distance)
        {
            return Ok(vehicleRepositoryService
                .getVehicleByParameter(teamName, model, ManufacturingDate, distance));
        }
    }
}
