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

        public PackageInfo NugetPackage
        {
            get { return _package; }
        }

        public string Title
        {
            get { return _package.Title; }
        }
        public string Version
        {
            get { return _package.Versions.FirstOrDefault()?.version; }
        }
        public string IconUrl
        {
            get { return _package.IconUrl; }
        }
        public string Summary
        {
            get { return _package.summary; }
        }
        public string Description
        {
            get { return _package.description; }
        }
    }
}