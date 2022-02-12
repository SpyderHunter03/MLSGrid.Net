using Newtonsoft.Json;

namespace MLSGrid
{
    public class Media
    {
        [JsonProperty("Order")]
        public int Order { get; set; }

        [JsonProperty("LongDescription")]
        public string? LongDescription { get; set; }

        [JsonProperty("MediaType")]
        public string? MediaType { get; set; }

        [JsonProperty("ImageWidth")]
        public int ImageWidth { get; set; }

        [JsonProperty("ImageHeight")]
        public int ImageHeight { get; set; }

        [JsonProperty("ImageSizeDescription")]
        public string? ImageSizeDescription { get; set; }

        [JsonProperty("MediaURL")]
        public string? MediaURL { get; set; }

        [JsonProperty("MediaModificationTimestamp")]
        public DateTime MediaModificationTimestamp { get; set; }

        [JsonProperty("MediaKey")]
        public string? MediaKey { get; set; }
    }
}
