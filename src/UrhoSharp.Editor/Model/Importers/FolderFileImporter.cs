using System.IO;

namespace UrhoSharp.Editor.Model.Importers
{
    public class FolderFileImporter : MultifileImporter
    {
        public FolderFileImporter(IImporter parent, string name) : base(parent, name)
        {
            foreach (var file in Directory.GetFiles(name)) Files.Add(CreateImporter(file));
        }
    }
}