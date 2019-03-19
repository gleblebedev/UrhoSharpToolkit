using System.Linq;

namespace UrhoSharp.AssetStore.Nuget
{
    public class Package : IAssetPackage
    {
        private PackageInfo _package;

        public Package(PackageInfo package)
        {
            this._package = package;
        }

        public string Title
        {
            get { return _package.Title; }
        }
        public string Version
        {
            get { return _package.versions.FirstOrDefault()?.version; }
        }
    }
}