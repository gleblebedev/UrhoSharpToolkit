namespace UrhoSharp.Editor.ViewModel
{
    public class FileViewModel : FileSystemItemViewModel
    {
        public FileViewModel(string fullPath, string rootPath, FileSystemItemViewModel parent, AssetsViewModel assets) :
            base(fullPath, rootPath, parent, assets)
        {
        }
    }
}