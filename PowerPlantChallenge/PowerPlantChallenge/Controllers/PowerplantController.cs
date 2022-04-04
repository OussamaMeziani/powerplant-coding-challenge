using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PowerPlantChallenge.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PowerPlantChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PowerplantController : ControllerBase
    {

        [HttpPost]
        public string Productionplan([FromBody] Payload payload)
        {
            return "test"; 
        }
    }
}
