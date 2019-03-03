using System;
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
            builder.RegisterType<HubWindowViewModel>().SingleInstance();
            builder.RegisterGeneric(typeof(ConfigurationContainer<>)).AsSelf().SingleInstance();

            // View models.
            builder.RegisterType<AssetsViewModel>().InstancePerLifetimeScope();
            builder.RegisterType<EditorViewModel>().InstancePerLifetimeScope();

            // Views.
            builder.RegisterType<EditorWindow>().InstancePerLifetimeScope();
            builder.RegisterType<AssetStoreWindow>().InstancePerLifetimeScope();
            builder.Register(GetAssetsView).As<AssetsView>().InstancePerLifetimeScope();

            // Misc.
            builder.RegisterType<AssetsWatcher>().As<IObservable<AssetFileEventArgs>>().InstancePerLifetimeScope();

            _container = builder.Build();
            MainWindow = _container.Resolve<HubWindow>();
            MainWindow.Show();
            ShutdownMode = ShutdownMode.OnLastWindowClose;
        }

        private AssetsView GetAssetsView(IComponentContext arg)
        {
            return arg.Resolve<EditorWindow>().AssetsView;
        }

        private void App_OnExit(object sender, ExitEventArgs e)
        {
            _container?.Dispose();
        }
    }
}