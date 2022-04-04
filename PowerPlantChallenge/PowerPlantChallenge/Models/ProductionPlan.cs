using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PowerPlantChallenge.Models
{
    public partial class ProductionPlan
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("p")]
        public long P { get; set; }
    }
}
