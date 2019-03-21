using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using UrhoSharp.AssetStore;
using UrhoSharp.Editor.Model;

namespace UrhoSharp.Editor.ViewModel
{
    public class AssetStoreViewModel:ViewModelBase
    {
        private readonly IAssetStore _store;
        private readonly ProjectConfiguration _configuration;
        private readonly ProjectReference _project;
        private string _searchText;
        private Subject<string> _searchTextObservable = new Subject<string>();
        private Subject<bool> _includePrereleaseObservable = new Subject<bool>();
        private bool _includePrerelease;
        private IList<AssetPackageViewModel> _assets;
        private IAssetPackage _currentPackage;
        private bool _hasPackage;
        private ICommand _closePackageCommand;
        private ICommand _installPackageCommand;

        public AssetStoreViewModel(IAssetStore store, IConfigurationContainer<ProjectConfiguration> configuration, ProjectReference project)
        {
            _store = store;
            _configuration = configuration.Value;
            _project = project;
            _searchTextObservable.StartWith(_searchText)
                .CombineLatest(_includePrereleaseObservable.StartWith(_includePrerelease),
                    (t, p) => new AssetStoreQueryArgs() {Text = t, IncludePrerelease = p})
                .Throttle(TimeSpan.FromSeconds(1))
                .Select(_ => _store.Query(_).ToObservable())
                .Switch()
                .ObserveOnDispatcher()
                .Subscribe(OnSearchResult);
            ClosePackageCommand = new ActionCommand(ClosePackage);
            InstallPackageCommand = new AsyncCommand(InstallPackage);
        }

        private async Task InstallPackage()
        {
            await _store.DownloadAssets(CurrentPackage, Path.Combine(_project.Path, _configuration.DataFolders.FirstOrDefault()), true);
        }

        public ICommand InstallPackageCommand
        {
            get { return _installPackageCommand; }
            set { _installPackageCommand = value; }
        }

        public ICommand ClosePackageCommand
        {
            get { return _closePackageCommand; }
            set { _closePackageCommand = value; }
        }

        void OnSearchResult(IList<IAssetPackage> packages)
        {
            Assets = packages.Select(_ => new AssetPackageViewModel(_) { SelectPackageCommand = new ActionCommand(()=>OpenPackage(_))}).ToList();
        }

        private void OpenPackage(IAssetPackage assetPackage)
        {
            CurrentPackage = assetPackage;
        }
        private void ClosePackage()
        {
            CurrentPackage = null;
        }

        public IAssetPackage CurrentPackage
        {
            get => _currentPackage;
            set
            {
                if (Set(ref _currentPackage, value))
                    HasPackage = _currentPackage != null;
            }
        }

        public bool HasPackage
        {
            get { return _hasPackage; }
            set { Set(ref _hasPackage, value); }
        }

        public IList<AssetPackageViewModel> Assets
        {
            get => _assets;
            set => Set(ref _assets, value);
        }

        public string SearchText
        {
            get => _searchText;
            set
            {
                if (Set(ref _searchText, value))
                    _searchTextObservable.OnNext(_searchText);
            }
        }

        public bool IncludePrerelease
        {
            get => _includePrerelease;
            set
            {
                if (Set(ref _includePrerelease, value))
                    _includePrereleaseObservable.OnNext(_includePrerelease);
            }
        }
    }
}
