using System.Diagnostics;
using System.IO;
using System.Windows.Input;
using Microsoft.Win32;
using UrhoSharp.Editor.Model;
using UrhoSharp.Editor.View;

namespace UrhoSharp.Editor.ViewModel
{
    public class FolderViewModel : FileSystemItemViewModel
    {
        public FolderViewModel(string fullPath, string rootPath, FileSystemItemViewModel parent, AssetsViewModel assets)
            : base(fullPath, rootPath, parent, assets)
        {
            OpenCommand = new ActionCommand(Select);
            ExportPackageCommand = new ActionCommand(ExportPackage);
        }

        public ICommand OpenCommand { get; set; }
        public ICommand ExportPackageCommand { get; set; }

        public string ResourcePath => Utils.GetResourceName(_rootPath, FullPath);


        private void ExportPackage()
        {
            var container = new JsonFileContainer<NugetPackageConfiguration>(Path.Combine(FullPath,
                NugetPackageConfiguration.ConfigurationFileName));

            var vm = new ExportPackageViewModel(container, this);
            var w = new ExportPackageWindow(vm);
            if (w.ShowDialog() == true)
            {
                var fileDialog = new SaveFileDialog();
                fileDialog.Filter = "nuget package (*.nupkg)|*.nupkg";
                fileDialog.FileName = vm.FileName;
                if (fileDialog.ShowDialog() == true) vm.Export(fileDialog.FileName);
            }
        }

        private void Select()
        {
            _assets.OpenFolder(this);
        }

        protected override void ViewInExplorer()
        {
            Process.Start("explorer.exe", FullPath);
        }
    }
}