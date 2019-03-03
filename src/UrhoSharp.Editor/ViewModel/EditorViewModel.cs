using System;
using System.Diagnostics;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using UrhoSharp.Editor.Model;
using UrhoSharp.Editor.View;

namespace UrhoSharp.Editor.ViewModel
{
    public class EditorViewModel : ViewModelBase
    {
        private readonly IConfigurationContainer<ProjectConfiguration> _configuration;
        private readonly ProjectReference _projectReference;
        private readonly Lazy<EditorWindow> _window;

        public EditorViewModel(ProjectReference projectReference,
            IConfigurationContainer<ProjectConfiguration> configuration,
            AssetsViewModel assets,
            Lazy<EditorWindow> window,
            Lazy<AssetStoreWindow> assetStore
        )
        {
            _projectReference = projectReference;
            _configuration = configuration;
            _window = window;
            Assets = assets;
            ExitCommand = new ActionCommand(Exit);
            AssetStoreCommand = new ActionCommand(AssetStore);
        }

        public ICommand AssetStoreCommand { get; }

        public ICommand ExitCommand { get; }

        public string Name => _projectReference.Name;

        public string Path => _projectReference.Path;

        public AssetsViewModel Assets { get; }

        private void AssetStore()
        {
            Process.Start("https://www.nuget.org/packages?q=Urho3DAsset");
        }

        private void Exit()
        {
            _window.Value.Close();
        }

        public void Edit(FileViewModel fileViewModel)
        {
        }
    }
}