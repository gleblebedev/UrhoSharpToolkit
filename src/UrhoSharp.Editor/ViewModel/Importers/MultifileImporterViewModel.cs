using System.Collections.Generic;
using System.IO;
using System.Linq;
using UrhoSharp.Editor.Model;
using UrhoSharp.Editor.Model.Importers;

namespace UrhoSharp.Editor.ViewModel.Importers
{
    public class MultifileImporterViewModel : AbstractImporterViewModel
    {
        private bool _createFolder = true;

        public MultifileImporterViewModel(MultifileImporter importer) : base(importer)
        {
            Files = importer.Files.Select(MakeViewModel).ToList();
        }

        public List<AbstractImporterViewModel> Files { get; set; }

        public bool CreateFolder
        {
            get => _createFolder;
            set => Set(ref _createFolder, value);
        }

        private AbstractImporterViewModel MakeViewModel(IImporter importer)
        {
            var multifile = importer as MultifileImporter;
            if (multifile != null) return new MultifileImporterViewModel(multifile);

            switch (importer.GetType().Name)
            {
                case nameof(BspFileImporter):
                    return new BspFileImporterViewModel(importer);
            }

            return new FileImporterViewModel(importer);
        }

        public void ImportTo(FolderViewModel targetFolder)
        {
            Import(targetFolder.FullPath);
        }

        public override void Import(string targetFolderFullPath)
        {
            if (!Enabled)
                return;
            if (_createFolder && !string.IsNullOrWhiteSpace(Name))
            {
                targetFolderFullPath = Path.Combine(targetFolderFullPath, Name);
                Directory.CreateDirectory(targetFolderFullPath);
            }

            foreach (var file in Files) file.Import(targetFolderFullPath);
        }
    }
}