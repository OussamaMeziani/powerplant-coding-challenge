using System.Collections.Generic;

namespace PowerPlantChallenge.Models
{
    public class Payload
    {
        public decimal Load { get; set; }
        public Fuels Fuels { get; set; }
        public List<Powerplant> Powerplants { get; set; }
    }
}
