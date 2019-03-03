using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Input;

namespace UrhoSharp.Editor.ViewModel
{
    public class FileViewModel : FileSystemItemViewModel
    {
        private readonly Lazy<FileInfo> _info;

        public FileViewModel(string fullPath, string rootPath, FileSystemItemViewModel parent, AssetsViewModel assets) :
            base(fullPath, rootPath, parent, assets)
        {
            _info = new Lazy<FileInfo>(() => new FileInfo(fullPath));
            EditCommand = new ActionCommand(Edit);
        }

        public long Size => _info.Value.Length;

        public ICommand EditCommand { get; }

        public string ResourceName => new Uri(_rootPath).MakeRelativeUri(new Uri(FullPath)).ToString();

        private void Edit()
        {
            _assets.Edit(this);
        }

        protected override void ViewInExplorer()
        {
            Process.Start("explorer.exe", "/select, " + FullPath);
        }

        public Stream OpenFile()
        {
            return File.Open(FullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        }
    }
}