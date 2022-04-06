using PowerPlantChallenge.Data.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace PowerPlantChallenge.Data.Models
{
    public class Powerplant
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public decimal Efficiency { get; set; }
        [Required]
        public int Pmin { get; set; }
        [Required]
        public int Pmax { get; set; }

        public FuelType PowerPlantType
        {
            get {
                switch (this.Type)
                {
                    case "gasfired": return FuelType.Gas;
                    case "turbojet": return FuelType.Kerosine;
                    case "windturbine": return FuelType.Wind;
                    default: return FuelType.Gas;
                }
            }
        }

        public decimal GetCostRatio(Fuels fuels)
        {
            decimal costratio = 0;
            switch(PowerPlantType)
            {
                case FuelType.Gas: costratio = fuels.Gas * Efficiency * Pmax; break;
                case FuelType.Kerosine: costratio = fuels.Kerosine * Efficiency * Pmax; break;
            }
            return costratio;
        }

        public decimal GetTotalPowerMin()
        {
            return Pmin * Efficiency;
        }

        public decimal GetTotalPowerMax()
        {
            return Pmax * Efficiency;
        }
    }
}
