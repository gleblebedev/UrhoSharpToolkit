using System.IO;
using GalaSoft.MvvmLight;
using UrhoSharp.Editor.Model;

namespace UrhoSharp.Editor.ViewModel.Importers
{
    public abstract class AbstractImporterViewModel : ViewModelBase
    {
        protected readonly IImporter _importer;
        private bool _enabled = true;

        protected AbstractImporterViewModel(IImporter importer)
        {
            _importer = importer;
            Name = Path.GetFileName(_importer.Name);
        }

        public IImporter Importer => _importer;

        public bool Enabled
        {
            get => _enabled;
            set => Set(ref _enabled, value);
        }

        public string Name { get; }

        public virtual void Import(string targetFolderFullPath)
        {
            if (!Enabled)
                return;
            _importer.Import(targetFolderFullPath);
        }
    }
}