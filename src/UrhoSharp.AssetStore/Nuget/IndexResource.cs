using Newtonsoft.Json;

namespace UrhoSharp.AssetStore.Nuget
{
    public class IndexResource
    {
        [JsonProperty("@id")]
        public string Id { get; set; }
        [JsonProperty("@type")]
        public string Type { get; set; }
        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}