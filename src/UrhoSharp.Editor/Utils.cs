using System;
using System.Web;

namespace UrhoSharp.Editor
{
    public static class Utils
    {
        public static string GetResourceName(string dataFolder, string fileFullPath)
        {
            var relUri = new Uri(dataFolder).MakeRelativeUri(new Uri(fileFullPath));
            return HttpUtility.UrlDecode(relUri.ToString());
            //return relUri.ToString();
        }
    }
}