using System;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using Urho;
using UrhoSharp.Pages;

namespace UrhoSharp.Editor.Model
{

    public class EditorApp : AbstractNavigationApp, IObservable<SceneChangeEventArgs>
    {
        private Subject<SceneChangeEventArgs> _sceneChanges;

        public EditorApp(ApplicationOptions options) : base(options)
        {
        }

        public EditorApp(IntPtr handle) : base(handle)
        {
        }

        protected EditorApp(UrhoObjectFlag emptyFlag) : base(emptyFlag)
        {
        }

        public IDisposable Subscribe(IObserver<SceneChangeEventArgs> observer)
        {
            return _sceneChanges.Subscribe(observer);
        }

        protected override async void Start()
        {
            _sceneChanges = new Subject<SceneChangeEventArgs>();
            base.Start();

#if DEBUG
            var MonoDebugHud = new MonoDebugHud(this);
            MonoDebugHud.Show();
#endif
            //await Navigation.PushAsync(new ScenePage("No scene.xml",false));
        }

        protected override void OnPageActivated(object sender, PageEventArgs e)
        {
            base.OnPageActivated(sender, e);
            var scene = (e.Page as AbstractSingleScenePage)?.Scene;
            if (scene != null)
            {
                scene.NodeAdded += OnNodeAdded;
                scene.ComponentAdded += OnComponentAdded;
            }

            _sceneChanges.OnNext(SceneChangeEventArgs.NewScene(scene));
        }

        private void OnComponentAdded(ComponentAddedEventArgs args)
        {
            _sceneChanges.OnNext(SceneChangeEventArgs.ComponentAdded(args));
        }

        private void OnNodeAdded(NodeAddedEventArgs args)
        {
            _sceneChanges.OnNext(SceneChangeEventArgs.NodeAdded(args));
        }

        protected override void OnPageDeactivated(object sender, PageEventArgs e)
        {
            base.OnPageDeactivated(sender, e);
            var scene = (e.Page as AbstractSingleScenePage)?.Scene;
            if (scene != null)
            {
                scene.NodeAdded -= OnNodeAdded;
                scene.ComponentAdded -= OnComponentAdded;
            }

            _sceneChanges.OnNext(SceneChangeEventArgs.NewScene(null));
        }

        public void OpenModel(string resourceName)
        {
            Task.Run(() => Navigation.ResetTo(new ModelPage(resourceName)));
        }

        public void OpenScene(string resourceName)
        {
            Task.Run(() => Navigation.ResetTo(new ScenePage(resourceName, false)));
        }

        public void OpenPrefab(string resourceName)
        {
            Task.Run(() => Navigation.ResetTo(new ScenePage(resourceName, true)));
        }
    }
}