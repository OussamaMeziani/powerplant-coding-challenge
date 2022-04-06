using Newtonsoft.Json;

namespace PowerPlantChallenge.Data.Models
{
    public partial class ProductionPlan
    {
        public ProductionPlan (string name , long price)
        {
            Name = name;
            P = price;
        }
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("p")]
        public long P { get; set; }
    }
}
