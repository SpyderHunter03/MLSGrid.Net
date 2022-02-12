using Newtonsoft.Json;

namespace MLSGrid
{
    public class PropertyRoom
    {
        [JsonProperty("RoomKey")]
        public string? RoomKey { get; set; }

        [JsonProperty("RoomDimensions")]
        public string? RoomDimensions { get; set; }

        [JsonProperty("RoomLength")]
        public int RoomLength { get; set; }

        [JsonProperty("RoomLevel")]
        public string? RoomLevel { get; set; }

        [JsonProperty("RoomType")]
        public string? RoomType { get; set; }

        [JsonProperty("RoomWidth")]
        public int RoomWidth { get; set; }

        [JsonProperty("MFR_RoomFlooring")]
        public string? MFRRoomFlooring { get; set; }

        [JsonProperty("RoomDescription")]
        public string? RoomDescription { get; set; }

        [JsonProperty("RoomFeatures")]
        public IEnumerable<string>? RoomFeatures { get; set; }
    }
}
