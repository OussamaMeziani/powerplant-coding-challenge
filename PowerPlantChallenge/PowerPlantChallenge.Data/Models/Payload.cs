using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerPlantChallenge.Data.Models
{
    public class Payload
    {
        [Required]
        public decimal Load { get; set; }
        public Fuels Fuels { get; set; }
        public List<Powerplant> Powerplants { get; set; }
    }
}
