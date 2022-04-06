using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PowerPlantChallenge.Data.Models
{
    public class Fuels
    {

        [JsonPropertyName("gas(euro/MWh)")]
        [Required]
        public decimal Gas { get; set; }
        [JsonPropertyName("kerosine(euro/MWh)")]
        [Required]
        public decimal Kerosine { get; set; }
        [JsonPropertyName("co2(euro/ton)")]
        [Required]
        public decimal CO2 { get; set; }
        [JsonPropertyName("wind(%)")]
        [Required]
        public decimal Wind { get; set; }
    }
}
