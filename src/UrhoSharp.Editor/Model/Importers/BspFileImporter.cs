using Toe.ContentPipeline.Bsp;

namespace UrhoSharp.Editor.Model.Importers
{
    public class BspFileImporter : AbstractImporter
    {
        private readonly BspFileFormat _bspFileFormat;

        public BspFileImporter(IImporter parent, string name, BspFileFormat bspFileFormat) : base(parent, name)
        {
            _bspFileFormat = bspFileFormat;
        }
    }
}