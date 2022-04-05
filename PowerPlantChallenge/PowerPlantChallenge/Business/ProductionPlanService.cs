using PowerPlantChallenge.Models;
using PowerPlantChallenge.Models.Enum;
using System;
using System.Collections.Generic;

namespace PowerPlantChallenge.Business
{
    public class ProductionPlanService : IProductionPlanService
    {
        public List<ProductionPlan> CalculateUnitCommitment(Payload payload)
        {
            decimal load = payload.Load;
            Fuels fuels = payload.Fuels;
            List<Powerplant> powerplants = payload.Powerplants;
            List<ProductionPlan> productionPlans = new List<ProductionPlan>();

            foreach(var powerplant in powerplants)
            {
                productionPlans.Add(new ProductionPlan(powerplant.Name, powerplant.Pmax/3));
            }

            //I didn't understand how to make the algoithm 
            //foreach(var powerplant in powerplants.OrderBy())
            //{
            //    if(load > 0)
            //    {
            //        switch(powerplant.GetPowerplanFuelType())
            //        {
            //            case FuelType.Gas:

            //                break ;

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
