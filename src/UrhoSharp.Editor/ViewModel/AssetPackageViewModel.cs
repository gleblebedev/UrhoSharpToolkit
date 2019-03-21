using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UrhoSharp.AssetStore;

namespace UrhoSharp.Editor.ViewModel
{
    public class AssetPackageViewModel
    {
        private readonly IAssetPackage _package;
        private ICommand _selectPackageCommand;

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
        public string IconUrl
        {
            get { return _package.IconUrl; }
        }
        public string Summary
        {
            get { return _package.Summary; }
        }
        public string Description
        {
            get { return _package.Description; }
        }

        public ICommand SelectPackageCommand
        {
            get { return _selectPackageCommand; }
            set { _selectPackageCommand = value; }
        }
    }
}
