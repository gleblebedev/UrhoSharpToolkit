using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using GalaSoft.MvvmLight;
using UrhoSharp.Editor.Model;
using UrhoSharp.Editor.View;

namespace UrhoSharp.Editor.ViewModel
{
    public class EditorViewModel : ViewModelBase
    {
        private readonly Func<EditorApp> _app;
        private readonly IConfigurationContainer<ProjectConfiguration> _configuration;
        private readonly ProjectReference _projectReference;
        private readonly Lazy<EditorWindow> _window;
        private bool _hasUnsavedChanged;

        public EditorViewModel(ProjectReference projectReference,
            IConfigurationContainer<ProjectConfiguration> configuration,
            AssetsViewModel assets,
            Lazy<EditorWindow> window,
            Lazy<AssetStoreWindow> assetStore,
            Func<EditorApp> app
        )
        {
            _projectReference = projectReference;
            _configuration = configuration;
            _window = window;
            _app = app;
            Assets = assets;
            ExitCommand = new ActionCommand(Exit);
            AssetStoreCommand = new ActionCommand(AssetStore);
        }

        public ICommand AssetStoreCommand { get; }

        public ICommand ExitCommand { get; }

        public string Name => _projectReference.Name;

        public string Path => _projectReference.Path;

        public AssetsViewModel Assets { get; }

        public bool HasUnsavedChanged
        {
            get => _hasUnsavedChanged;
            set => Set(ref _hasUnsavedChanged, value);
        }

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
            if (HasUnsavedChanged)
                if (MessageBox.Show(
                        "You have unsaved changed in a current file. Do you want to open " + fileViewModel.Name +
                        " anyway?", "WARNING", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                    return;

            var ext = System.IO.Path.GetExtension(fileViewModel.Name).ToLower();
            switch (ext)
            {
                case ".mdl":
                    OpenModelFile(fileViewModel);
                    break;
                case ".xml":
                    OpenXmlFile(fileViewModel);
                    break;
            }
        }

        private void OpenModelFile(FileViewModel fileViewModel)
        {
            _app()?.OpenModel(fileViewModel.ResourceName);
        }
        private void OpenXmlFile(FileViewModel fileViewModel)
        {
            var doc = XDocument.Load(fileViewModel.FullPath);
            switch (doc.Root.Name.LocalName)
            {
                case "scene":
                    _app()?.OpenScene(fileViewModel.FullPath);
                    break;
                case "node":
                    _app()?.OpenPrefab(fileViewModel.ResourceName);
                    break;
            }
        }
    }
}