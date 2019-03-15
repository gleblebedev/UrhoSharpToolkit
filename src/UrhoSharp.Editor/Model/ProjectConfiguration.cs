namespace UrhoSharp.Editor.Model
{
    public class ProjectConfiguration
    {
        private string _metaInfoFolder;
        public string Name { get; set; }

        public string MetaInfoFolder
        {
            get => _metaInfoFolder ?? (_metaInfoFolder = ".meta");
            set => _metaInfoFolder = value;
        }

        public string[] DataFolders { get; set; } = {"Data"};
    }
}