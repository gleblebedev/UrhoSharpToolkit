using Newtonsoft.Json;

namespace UrhoSharp.AssetStore.Nuget
{
    public class PackageVesionRef
    {
        [JsonProperty("@id")]
        public string Url { get; set; }

        [JsonProperty("version")]
        public string version { get; set; }

        [JsonProperty("downloads")]
        public int downloads { get; set; }
    }
}