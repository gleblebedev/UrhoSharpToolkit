using System.Collections.Generic;
using UrhoSharp.Editor.Model.Importers;
using UrhoSharp.Editor.ViewModel.Importers;

namespace UrhoSharp.Editor.ViewModel
{
    public class ImportAssetsViewModel
    {
        private readonly MultifileImporterViewModel _batch;

        public ImportAssetsViewModel(string[] files, FolderViewModel viewModelSelectedFolder)
        {
            _batch = new MultifileImporterViewModel(new BatchImporter(files));
        }

        public List<AbstractImporterViewModel> Files => _batch.Files;

        public void ImportAssets(FolderViewModel targetFolder)
        {
            _batch.ImportTo(targetFolder);
        }
    }
}