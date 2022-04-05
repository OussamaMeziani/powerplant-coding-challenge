using PowerPlantChallenge.Models;
using System.Collections.Generic;

namespace PowerPlantChallenge.Business
{
    public interface IProductionPlanService
    {
        List<ProductionPlan> CalculateUnitCommitment(Payload payload);
    }
}
