using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using UrhoSharp.AssetStore;

namespace UrhoSharp.Editor.ViewModel
{
    public class AssetStoreViewModel:ViewModelBase
    {
        private readonly IAssetStore _store;
        private string _searchText;
        private Subject<string> _searchTextObservable = new Subject<string>();
        private Subject<bool> _includePrereleaseObservable = new Subject<bool>();
        private bool _includePrerelease;
        private IList<AssetPackageViewModel> _assets;

        public AssetStoreViewModel(IAssetStore store)
        {
            _store = store;
            _searchTextObservable.StartWith(_searchText)
                .CombineLatest(_includePrereleaseObservable.StartWith(_includePrerelease),
                    (t, p) => new AssetStoreQueryArgs() {Text = t, IncludePrerelease = p})
                .Throttle(TimeSpan.FromSeconds(1))
                .Select(_ => _store.Query(_).ToObservable())
                .Switch()
                .ObserveOnDispatcher()
                .Subscribe(OnSearchResult);
        }

        void OnSearchResult(IList<IAssetPackage> packages)
        {
            Assets = packages.Select(_ => new AssetPackageViewModel(_)).ToList();
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
