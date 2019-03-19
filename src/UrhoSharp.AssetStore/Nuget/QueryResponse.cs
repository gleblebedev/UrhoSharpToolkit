using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UrhoSharp.AssetStore.Nuget
{
    public class QueryResponse
    {
        [JsonProperty("totalHits")]
        public int totalHits { get; set; }
        [JsonProperty("data")]
        public IList<PackageInfo> data { get; set; }

    }
}