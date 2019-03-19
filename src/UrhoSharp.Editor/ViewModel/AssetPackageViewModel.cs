using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrhoSharp.AssetStore;

namespace UrhoSharp.Editor.ViewModel
{
    public class AssetPackageViewModel
    {
        private readonly IAssetPackage _package;

        public AssetPackageViewModel(IAssetPackage package)
        {
            _package = package;
        }
        public string Title
        {
            get { return _package.Title; }
        }
        public string Version
        {
            get { return _package.Version; }
        }
    }
}
