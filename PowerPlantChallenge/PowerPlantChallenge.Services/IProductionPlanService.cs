using PowerPlantChallenge.Data.Models;
using System.Collections.Generic;

namespace PowerPlantChallenge.Services
{
    public interface IProductionPlanService
    {
        List<ProductionPlan> CalculateUnitCommitment(Payload payload);
    }
}
