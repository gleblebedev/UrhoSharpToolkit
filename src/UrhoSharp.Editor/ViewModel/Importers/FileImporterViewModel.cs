using UrhoSharp.Editor.Model;
using UrhoSharp.Editor.Model.Importers;

namespace UrhoSharp.Editor.ViewModel.Importers
{
    public class FileImporterViewModel : AbstractImporterViewModel
    {
        public FileImporterViewModel(IImporter importer) : base(importer)
        {
        }

        public new FileImporter Importer => (FileImporter) base.Importer;
    }
}