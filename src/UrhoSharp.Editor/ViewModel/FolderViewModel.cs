using System.Diagnostics;
using System.Windows.Input;

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

        private void ExportPackage()
        {
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