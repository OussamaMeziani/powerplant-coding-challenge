namespace PowerPlantChallenge.Data.Models
{
    public partial class ProductionPlan
    {
        public ProductionPlan (string name , decimal power)
        {
            Name = name;
            P = power;
        }
        public string Name { get; set; }
        public decimal P { get; set; }
    }
}
