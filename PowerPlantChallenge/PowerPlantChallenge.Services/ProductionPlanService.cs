using PowerPlantChallenge.Data.Models;
using PowerPlantChallenge.Data.Models.Enum;
using System.Collections.Generic;

namespace PowerPlantChallenge.Services
{
    public class ProductionPlanService : IProductionPlanService
    {
        public List<ProductionPlan> CalculateUnitCommitment(Payload payload)
        {
            decimal load = payload.Load;
            Fuels fuels = payload.Fuels;
            List<Powerplant> powerplants = payload.Powerplants;
            List<ProductionPlan> productionPlans = new List<ProductionPlan>();

            foreach (var powerplant in powerplants)
            {
                productionPlans.Add(new ProductionPlan(powerplant.Name, powerplant.Pmax / 3));
            }
            //foreach (var powerplant in powerplants)
            //{
            //    if (load > 0)
            //    {
            //        switch (powerplant.GetPowerplanFuelType())
            //        {
            //            case FuelType.Gas:

            //                break;

            //            case FuelType.Kerosine:
            //                break;

            //            case FuelType.Wind:
            //                break;
            //        }
            //    }
            //}
            return productionPlans;
        }
    }
}
