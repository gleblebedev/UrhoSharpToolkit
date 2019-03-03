using System;
using System.Collections.Generic;
using System.IO;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using GalaSoft.MvvmLight;
using UrhoSharp.Editor.Model;

namespace UrhoSharp.Editor.ViewModel
{
    public class AssetsViewModel : ViewModelBase, IDisposable
    {
        private readonly IConfigurationContainer<ProjectConfiguration> _configuration;
        private readonly ProjectReference _projectReference;
        private readonly CompositeDisposable _disposables;

        private FolderViewModel _selectedFolder;

        public AssetsViewModel(
            IObservable<AssetFileEventArgs> watcher,
            ProjectReference projectReference,
            IConfigurationContainer<ProjectConfiguration> configuration)
        {
            _projectReference = projectReference;
            _configuration = configuration;
            _disposables = new CompositeDisposable();
            _disposables.Add(watcher.ObserveOnDispatcher().Subscribe(OnAssetChanged));
            foreach (var configurationDataFolder in _configuration.Value.DataFolders)
            {
                var folder = Path.Combine(_projectReference.Path, configurationDataFolder);
                Folders.Add(new FolderViewModel(folder, folder, null, this));
            }
        }

        public IList<FolderViewModel> Folders { get; } = new List<FolderViewModel>();

        public FolderViewModel SelectedFolder
        {
            get => _selectedFolder;
            set => Set(ref _selectedFolder, value);
        }


        public void Dispose()
        {
            _disposables.Dispose();
        }

        private void OnAssetChanged(AssetFileEventArgs e)
        {
            foreach (var folder in Folders)
                if (e.FullPath.StartsWith(folder.FullPath))
                {
                    var path = (IReadOnlyList<string>) e.FullPath.Substring(folder.FullPath.Length)
                        .Split(Path.DirectorySeparatorChar);
                    if (path.Count > 0 && string.IsNullOrWhiteSpace(path[0]))
                        path = new ListTail<string>(path, 1);
                    folder.OnAssetChanged(path, e);
                }
        }

        public void OpenFolder(FolderViewModel folderViewModel)
        {
        }
    }
}