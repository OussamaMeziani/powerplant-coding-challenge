using System;
using System.Collections.Generic;
using System.Linq;
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
        public IActionResult Productionplan([FromBody] Payload payload)
        {
            try
            {
                logger.LogInformation("Starting processing the request...");
                List<ProductionPlan> productionplans = productionPlanService.CalculateUnitCommitment(payload);
                if (productionplans.Any())
                {
                    logger.LogInformation("Finished processing the request !");
                    return Ok(productionplans);
                }
                else
                    throw new Exception("Couldn't calculate the amount of energy");
            }
            catch(Exception ex)
            {
                logger.LogError($"{ex}");
                return Problem();
            }
           
        }
    }
}
