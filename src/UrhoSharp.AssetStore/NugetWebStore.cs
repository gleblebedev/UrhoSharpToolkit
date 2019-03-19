using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using UrhoSharp.AssetStore.Nuget;

namespace UrhoSharp.AssetStore
{
    public class NugetWebStore: IAssetStore
    {
        //https://api-v2v3search-0.nuget.org/query?q=Tags:Urho3DAsset&prerelease=true
        public async Task<IList<IAssetPackage>> Query(AssetStoreQueryArgs text)
        {
            var client = new WebClient();
            var index = await DownloadJson<Index>("https://api.nuget.org/v3/index.json");
            var queryService = index.resources.FirstOrDefault(_ => _.Type == "SearchQueryService");
            var response = await DownloadJson<QueryResponse>(queryService.Id+ "?q="+ HttpUtility.UrlEncode(text+" Tags:Urho3DAsset") +"&prerelease="+text.IncludePrerelease.ToString().ToLower());
            return response.data.Select(_ => (IAssetPackage)new Nuget.Package(_)).ToList();
        }

        public async Task<T> DownloadJson<T>(string url)
        {
            var client = new WebClient();
            var json = await client.DownloadStringTaskAsync(url);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
