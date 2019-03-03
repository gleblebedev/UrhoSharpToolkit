using GalaSoft.MvvmLight;
using UrhoSharp.Editor.Model;

namespace UrhoSharp.Editor.ViewModel
{
    public class EditorViewModel : ViewModelBase
    {
        private readonly IConfigurationContainer<ProjectConfiguration> _configuration;
        private readonly ProjectReference _projectReference;

        public EditorViewModel(ProjectReference projectReference,
            IConfigurationContainer<ProjectConfiguration> configuration,
            AssetsViewModel assets)
        {
            _projectReference = projectReference;
            _configuration = configuration;
            Assets = assets;
        }

        public string Name => _projectReference.Name;

        public string Path => _projectReference.Path;

        public AssetsViewModel Assets { get; }
    }
}