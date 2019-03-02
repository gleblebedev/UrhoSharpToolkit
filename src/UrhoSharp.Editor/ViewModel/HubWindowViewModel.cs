using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Input;
using Autofac;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using UrhoSharp.Editor.Model;
using UrhoSharp.Editor.View;

namespace UrhoSharp.Editor.ViewModel
{
    public class HubWindowViewModel : ViewModelBase
    {
        public static readonly string ProjectFileName = "urhoproject.json";
        private readonly ConfigurationContainer<HubConfiguration> _configuration;
        private readonly ILifetimeScope _rootScope;
        private IList<ProjectReferenceViewModel> _projects;

        public HubWindowViewModel(ConfigurationContainer<HubConfiguration> configuration, ILifetimeScope rootScope)
        {
            _configuration = configuration;
            _rootScope = rootScope;
            ResetProjects();
            OpenCommand = new RelayCommand(Open);
            NewCommand = new RelayCommand(New);
            LearnCommand = new RelayCommand(Learn);
        }

        public RelayCommand<ProjectReferenceViewModel> OpenProjCommand { get; set; }

        public RelayCommand LearnCommand { get; set; }

        public RelayCommand NewCommand { get; set; }

        public ICommand OpenCommand { get; set; }


        public IList<ProjectReferenceViewModel> Projects
        {
            get => _projects;
            set => Set(ref _projects, value);
        }

        private void ResetProjects()
        {
            Projects = _configuration.Value.Projects.Select(_ => new ProjectReferenceViewModel(_, this)).ToList();
        }


        private void Learn()
        {
            Process.Start("https://urho3d.github.io/");
        }

        private void New()
        {
            var ofd = new SaveFileDialog();
            ofd.Filter = GetFilter();
            ofd.FileName = ProjectFileName;
            if (ofd.ShowDialog() == true)
            {
                var folder = ofd.FileName;
                if (Path.GetFileName(ofd.FileName) == ProjectFileName)
                    folder = Path.GetDirectoryName(ofd.FileName);
                Directory.CreateDirectory(folder);
                OpenProject(new ProjectReference {Name = Path.GetFileName(folder), Path = folder}, true);
            }
        }

        private void Open()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = GetFilter();
            ofd.FileName = ProjectFileName;
            if (ofd.ShowDialog() == true)
            {
                var folder = ofd.FileName;
                if (Path.GetFileName(ofd.FileName) == ProjectFileName)
                    folder = Path.GetDirectoryName(ofd.FileName);
                Directory.CreateDirectory(folder);
                OpenProject(new ProjectReference {Name = Path.GetFileName(folder), Path = folder}, false);
            }
        }

        private static string GetFilter()
        {
            return "Project file (" + ProjectFileName + ")|" + ProjectFileName;
        }

        public void OpenProject(ProjectReference reference, bool initializeProject)
        {
            var scope = _rootScope.BeginLifetimeScope(_ => { PrepareContainer(reference, _); });
            if (initializeProject)
            {
                var proj = scope.Resolve<IConfigurationContainer<ProjectConfiguration>>();
                if (string.IsNullOrWhiteSpace(proj.Value.Name))
                    proj.Value.Name = reference.Name;
                proj.Save();
            }

            for (var index = 0; index < _configuration.Value.Projects.Count; index++)
            {
                var oldProject = _configuration.Value.Projects[index];
                if (oldProject.Path == reference.Path) _configuration.Value.Projects.RemoveAt(index);
            }

            _configuration.Value.Projects.Insert(0, reference);
            _configuration.Save();
            ResetProjects();

            var editor = scope.Resolve<EditorWindow>();
            editor.Show();

            var w =_rootScope.Resolve<HubWindow>();
            w.Dispatcher.BeginInvoke((Action)(() => w.Close()));
        }

        private static void PrepareContainer(ProjectReference reference, ContainerBuilder builder)
        {
            builder.RegisterInstance(reference);
            builder.RegisterInstance(
                    new JsonFileContainer<ProjectConfiguration>(Path.Combine(reference.Path, ProjectFileName)))
                .As<IConfigurationContainer<ProjectConfiguration>>();
        }
    }
}