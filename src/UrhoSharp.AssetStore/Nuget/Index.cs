using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UrhoSharp.AssetStore.Nuget
{
    public class Index
    {
        [JsonProperty("version")]
        public Version version { get; set; }
        [JsonProperty("resources")]
        public IList<IndexResource> resources { get; set; }
    }
}