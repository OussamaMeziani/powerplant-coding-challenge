using PowerPlantChallenge.Data.Models;
using PowerPlantChallenge.Data.Models.Enum;
using System.Collections.Generic;
using System.Linq;

namespace PowerPlantChallenge.Services
{
    public class ProductionPlanService : IProductionPlanService
    {
        public List<ProductionPlan> CalculateUnitCommitment(Payload payload)
        {
            decimal loadRequired = payload.Load;
            Fuels fuels = payload.Fuels;
            List<Powerplant> powerplants = payload.Powerplants;
            List<ProductionPlan> productionPlans = new List<ProductionPlan>();

            foreach (var powerplant in powerplants.OrderBy(p => p.GetCostRatio(fuels)).ThenBy(p => p.PowerPlantType == FuelType.Wind))
            {
                if(loadRequired > 0)
                {
                    if(powerplant.PowerPlantType != FuelType.Wind)
                    {
                        if (powerplant.GetTotalPowerMax() < loadRequired)
                        {
                            loadRequired -= powerplant.GetTotalPowerMax();
                            productionPlans.Add(new ProductionPlan(powerplant.Name, powerplant.GetTotalPowerMax()));
                        }
                        else
                        {
                            productionPlans.Add(new ProductionPlan(powerplant.Name, loadRequired / powerplant.Efficiency));
                            break;
                        }
                    }
                    else
                    {
                        decimal windpower = powerplant.Pmax * powerplant.Efficiency * (fuels.Wind / 100); // formule power wind
                        if (windpower < loadRequired)
                        {
                            loadRequired -= windpower;
                            productionPlans.Add(new ProductionPlan(powerplant.Name, windpower));
                        }
                        else
                        {
                            decimal rest = (loadRequired / powerplant.Efficiency) / (fuels.Wind / 100);
                            loadRequired -= windpower;
                            productionPlans.Add(new ProductionPlan(powerplant.Name, rest));
                        }
                    }
                    
                }
            }
            return productionPlans;

        }
    }
}
