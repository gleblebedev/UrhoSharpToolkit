using System.Windows;
using Autofac;
using UrhoSharp.Editor.Model;
using UrhoSharp.Editor.View;
using UrhoSharp.Editor.ViewModel;

namespace UrhoSharp.Editor
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IContainer _container;

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<HubWindow>().SingleInstance();
            builder.RegisterType<EditorWindow>().InstancePerLifetimeScope();
            builder.RegisterType<EditorViewModel>().InstancePerLifetimeScope();
            builder.RegisterType<HubWindowViewModel>().SingleInstance();
            builder.RegisterGeneric(typeof(ConfigurationContainer<>)).AsSelf().SingleInstance();
            _container = builder.Build();
            MainWindow = _container.Resolve<HubWindow>();
            MainWindow.Show();
        }

        private void App_OnExit(object sender, ExitEventArgs e)
        {
            _container?.Dispose();
        }
    }
}