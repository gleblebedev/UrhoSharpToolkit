using System.Collections.Generic;
using System.IO;
using Toe.ContentPipeline.Bsp;
using Toe.ContentPipeline.Vox;

namespace UrhoSharp.Editor.Model.Importers
{
    public class MultifileImporter : AbstractImporter
    {
        private IList<IImporter> _files;

        public MultifileImporter(IImporter parent, string name) : base(parent, name)
        {
        }

        public IList<IImporter> Files
        {
            get => _files ?? (_files = new List<IImporter>());
            protected set => _files = value;
        }

        protected IImporter CreateImporter(string file)
        {
            if (Directory.Exists(file)) return new FolderFileImporter(this, file);

            var ext = System.IO.Path.GetExtension(file).ToLowerInvariant();
            switch (ext)
            {
                case ".zip":
                    return new ZipFileImporter(this, file);
                    break;
                case ".vox":
                    return new SceneFileImporter(this, file, new VoxFileFormat());
                case ".bsp":
                    return new BspFileImporter(this, file, new BspFileFormat());
                case ".nupkg":
                    return new NugetFileImporter(this, file);
                    break;
                default:
                    return new FileImporter(this, file);
                    break;
            }
        }
    }
}