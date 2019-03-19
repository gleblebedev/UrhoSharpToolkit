using Newtonsoft.Json;

namespace UrhoSharp.AssetStore.Nuget
{
    public class PackageInfo
    {
        [JsonProperty("@id")]
        public string Url { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("iconUrl")]
        public string iconUrl { get; set; }

        [JsonProperty("licenseUrl")]
        public string licenseUrl { get; set; }

        [JsonProperty("projectUrl")]
        public string projectUrl { get; set; }

        [JsonProperty("summary")]
        public string summary { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("versions")]
        public PackageVesionRef[] versions { get; set; }

    }
}