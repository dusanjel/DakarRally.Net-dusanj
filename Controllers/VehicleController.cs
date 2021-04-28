﻿using DakarRally.Net_dusanj.Service.Dto;
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
        public IActionResult Post([FromBody] VehicleDto vehicle)
        {
            vehicleRepositoryService.SaveVehicle(vehicle);

            return Ok();
        }
    }
}