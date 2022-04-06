﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PowerPlantChallenge.Data.Models;
using PowerPlantChallenge.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PowerPlantChallenge.Controllers
{
    [Route("api/productionplan")]
    [ApiController]
    public class PowerplantController : ControllerBase
    {
        private readonly ILogger<PowerplantController> logger;
        private IProductionPlanService productionPlanService;
        public PowerplantController(IProductionPlanService productionPlanService , ILogger<PowerplantController> logger)
        {
            this.productionPlanService = productionPlanService;
            this.logger = logger;
        }

        [HttpPost]
        public List<ProductionPlan> Productionplan([FromBody] Payload payload)
        {
            try
            {
                logger.LogInformation($"{0} Starting processing the request...", DateTime.UtcNow.ToLongDateString());
                return productionPlanService.CalculateUnitCommitment(payload);
            }
            catch(Exception ex)
            {
                logger.LogError($"{0} Error - {1}", DateTime.UtcNow.ToLongDateString(),  ex);
                return new List<ProductionPlan>();
            }
           
        }
    }
}
