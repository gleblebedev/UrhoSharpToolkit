using Newtonsoft.Json;

namespace UrhoSharp.AssetStore.Nuget
{
    public class PackageVesion
    {
        [JsonProperty("@id")]
        public string Url { get; set; }

        [JsonProperty("packageContent")]
        public string packageContentUrl { get; set; }
    }
}