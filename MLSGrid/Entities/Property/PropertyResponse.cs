using Newtonsoft.Json;

namespace MLSGrid
{
    public class PropertyResponse
    {
        [JsonProperty("@odata.context")]
        public string? Context { get; set; }

        [JsonProperty("value")]
        public IEnumerable<Property>? Properties { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string? NextLink { get; set; }
    }
}
