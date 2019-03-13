using System;
using System.Reactive.Subjects;
using System.Windows;
using Autofac;
using UrhoSharp.Editor.Model;
using UrhoSharp.Editor.View;
using UrhoSharp.Editor.ViewModel;
using UnhandledExceptionEventArgs = Urho.UnhandledExceptionEventArgs;

namespace UrhoSharp.Editor
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Subject<EditorApp> _appSubject;
        private IContainer _container;

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            Urho.Application.UnhandledException += HandleUnhandledException;

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
            //builder.Register(GetEditorApp).As<EditorApp>().InstancePerDependency().ExternallyOwned();

            _appSubject = new Subject<EditorApp>();
            builder.RegisterInstance(_appSubject).As<IObservable<EditorApp>>().SingleInstance();
            Urho.Application.Started += () => _appSubject.OnNext(Urho.Application.Current as EditorApp);

            // Misc.
            _log = new Subject<LogMessage>();
            builder.RegisterInstance(_log).As<IObservable<LogMessage>>().SingleInstance();
            builder.RegisterType<MD5HashFunction>().As<IHashFunction>().SingleInstance();
            builder.RegisterType<PreviewFactory>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<LogViewModel>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<StatusBarViewModel>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<AssetsWatcher>().As<IObservable<AssetFileEventArgs>>().InstancePerLifetimeScope();
            _container = builder.Build();
            MainWindow = _container.Resolve<HubWindow>();
            MainWindow.Show();
            ShutdownMode = ShutdownMode.OnLastWindowClose;
        }

        private Subject<LogMessage> _log;
        private void HandleUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            _log.OnNext(new LogMessage(e));
        }

        private AssetsView GetAssetsView(IComponentContext arg)
        {
            return arg.Resolve<EditorWindow>().AssetsView;
        }

        private void App_OnExit(object sender, ExitEventArgs e)
        {
            _appSubject.OnCompleted();
            _container?.Dispose();
        }
    }
}