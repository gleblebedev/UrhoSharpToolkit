using System.Collections.Generic;

namespace UrhoSharp.Editor.Model.Importers
{
    public class BatchImporter : MultifileImporter
    {
        public BatchImporter(string[] files) : base(null, "")
        {
            Files = new List<IImporter>(files.Length);
            foreach (var file in files) Files.Add(CreateImporter(file));
        }
    }
}