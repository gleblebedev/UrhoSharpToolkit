using System;
using System.IO;
using System.Web;

namespace UrhoSharp.Editor
{
    public static class Utils
    {
        public static string GetResourceName(string dataFolder, string fileFullPath)
        {
            if (!dataFolder.EndsWith(Path.DirectorySeparatorChar.ToString()))
                dataFolder += Path.DirectorySeparatorChar;
            var relUri = new Uri(dataFolder).MakeRelativeUri(new Uri(fileFullPath));
            return HttpUtility.UrlDecode(relUri.ToString());
            //return relUri.ToString();
        }
    }
}