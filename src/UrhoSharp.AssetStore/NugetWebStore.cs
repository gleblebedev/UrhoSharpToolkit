using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
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

        public async Task DownloadAssets(IAssetPackage currentPackage, string dataFolder, bool overrideFiles)
        {
            var package = (Package)currentPackage;
            var version = package.NugetPackage.Versions.FirstOrDefault();
            var info = await DownloadJson<PackageVesion>(version.Url);
            var content = WebRequest.CreateHttp(info.packageContentUrl);
            var response = await content.GetResponseAsync();
            using (response)
            {
                using (var stream = response.GetResponseStream())
                {
                    var archive = new ZipArchive(stream, ZipArchiveMode.Read);
                    foreach (var entry in archive.Entries)
                    {
                        Trace.WriteLine(entry.FullName);
                        var prefixes = new[] {"Content/Data/"};
                        foreach (var prefix in prefixes)
                        {
                            if (entry.FullName.StartsWith(prefix, StringComparison.InvariantCultureIgnoreCase))
                            {
                                var resourceName = entry.FullName.Substring(prefix.Length);
                                var dstFileName = Path.Combine(dataFolder, resourceName);
                                if (!overrideFiles && File.Exists(dstFileName))
                                    return;
                                var tmpFileName = dstFileName + ".download";
                                Directory.CreateDirectory(Path.GetDirectoryName(dstFileName));
                                using (var fileStream = entry.Open())
                                {
                                    byte[] buf = new byte[4096];
                                    using (var tmpFile = File.Open(tmpFileName, FileMode.Create, FileAccess.Write,
                                        FileShare.Read))
                                    {
                                        for (;;)
                                        {
                                            var len = await fileStream.ReadAsync(buf, 0, buf.Length);
                                            if (len <= 0)
                                                break;
                                            await tmpFile.WriteAsync(buf, 0, len);
                                        }
                                    }
                                }
                                if (overrideFiles && File.Exists(dstFileName))
                                    File.Delete(dstFileName);
                                File.Move(tmpFileName, dstFileName);
                                break;
                            }
                        }
                    }
                }
            }
        }

        public async Task<T> DownloadJson<T>(string url)
        {
            var client = new WebClient();
            var json = await client.DownloadStringTaskAsync(url);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
