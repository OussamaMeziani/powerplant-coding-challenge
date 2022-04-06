namespace PowerPlantChallenge.Data.Models
{
    public partial class ProductionPlan
    {
        public ProductionPlan (string name , long price)
        {
            Name = name;
            P = price;
        }
        public string Name { get; set; }
        public long P { get; set; }
    }
}
