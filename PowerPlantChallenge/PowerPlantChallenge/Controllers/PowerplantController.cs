using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PowerPlantChallenge.Business;
using PowerPlantChallenge.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PowerPlantChallenge.Controllers
{
    [Route("api/productionplan")]
    [ApiController]
    [ApiVersion("1.0")]
    public class PowerplantController : ControllerBase
    {
        private readonly ILogger<PowerplantController> logger;
        private IProductionPlanService productionPlanService;
        public PowerplantController(ILogger<PowerplantController> logger , IProductionPlanService productionPlanService)
        {
            this.logger = logger;
            this.productionPlanService = productionPlanService;
        }

        [HttpPost]
        public List<ProductionPlan> Productionplan([FromBody] Payload payload)
        {
            try
            {
                logger.LogInformation($"{0} Starting processing the request...", DateTime.UtcNow);
                return productionPlanService.CalculateUnitCommitment(payload);
            }
            catch(Exception ex)
            {
                logger.LogError($"{0} Error - {1}", DateTime.UtcNow, ex);
                return new List<ProductionPlan>();
            }
           
        }
    }
}
