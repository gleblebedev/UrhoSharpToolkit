using System.Windows.Input;
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

        public string Title => _package.Title;

        public string Version => _package.Version;

        public string IconUrl => _package.IconUrl;

        public string Summary => _package.Summary;

        public string Description => _package.Description;

        public ICommand SelectPackageCommand { get; set; }
    }
}