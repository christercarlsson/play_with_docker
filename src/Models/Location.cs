using Newtonsoft.Json;

namespace tinywebapp.Models {
    
    public partial class Location
    {
        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postcode")]
        public long Postcode { get; set; }
    }
}