using System;
using System.Collections.Generic;
using System.IO;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using GalaSoft.MvvmLight;
using UrhoSharp.Editor.Model;
using UrhoSharp.Editor.View;

namespace UrhoSharp.Editor.ViewModel
{
    public class AssetsViewModel : ViewModelBase, IDisposable
    {
        private readonly Lazy<AssetsView> _assets;
        private readonly PreviewFactory _previewFactory;
        private readonly IConfigurationContainer<ProjectConfiguration> _configuration;
        private readonly CompositeDisposable _disposables;
        private readonly Lazy<EditorViewModel> _editor;
        private readonly ProjectReference _projectReference;

        private FolderViewModel _selectedFolder;

        public AssetsViewModel(
            IObservable<AssetFileEventArgs> watcher,
            ProjectReference projectReference,
            IConfigurationContainer<ProjectConfiguration> configuration,
            Lazy<AssetsView> assets,
            PreviewFactory previewFactory,
            Lazy<EditorViewModel> editor)
        {
            _projectReference = projectReference;
            _configuration = configuration;
            _assets = assets;
            _previewFactory = previewFactory;
            _editor = editor;
            _disposables = new CompositeDisposable();
            _disposables.Add(watcher.ObserveOnDispatcher().Subscribe(OnAssetChanged));
            foreach (var configurationDataFolder in _configuration.Value.DataFolders)
            {
                var folder = Path.Combine(_projectReference.Path, configurationDataFolder);
                if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
                    folder += Path.DirectorySeparatorChar;
                Folders.Add(new FolderViewModel(folder, folder, null, this));
            }
        }

        public IList<FolderViewModel> Folders { get; } = new List<FolderViewModel>();

        public FolderViewModel SelectedFolder
        {
            get => _selectedFolder;
            set => Set(ref _selectedFolder, value);
        }

        public PreviewFactory PreviewFactory
        {
            get { return _previewFactory; }
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
            _assets.Value.OpenFolder(folderViewModel);
        }

        public void Edit(FileViewModel fileViewModel)
        {
            _editor.Value.Edit(fileViewModel);
        }


        public class Search : IObservable<NugetPackageViewModel>
        {
            public string SearchText { get; set; }

            public IDisposable Subscribe(IObserver<NugetPackageViewModel> observer)
            {
                var q = new Query(SearchText, observer);
                return q;
            }

            private class Query : IDisposable
            {
                private readonly IObserver<NugetPackageViewModel> _observer;

                public Query(string text, IObserver<NugetPackageViewModel> observer)
                {
                    _observer = observer;
                }

                public void Dispose()
                {
                }
            }
        }
    }
}