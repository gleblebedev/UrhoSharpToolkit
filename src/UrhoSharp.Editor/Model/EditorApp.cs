using System;
using Urho;
using UrhoSharp.Pages;

namespace UrhoSharp.Editor.Model
{
    public class EditorApp : AbstractNavigationApp
    {
        public EditorApp(ApplicationOptions options) : base(options)
        {
        }

        public EditorApp(IntPtr handle) : base(handle)
        {
        }

        protected EditorApp(UrhoObjectFlag emptyFlag) : base(emptyFlag)
        {
        }


        protected override async void Start()
        {
            base.Start();

#if DEBUG
            var MonoDebugHud = new MonoDebugHud(this);
            MonoDebugHud.Show();
#endif
            await Navigation.PushAsync(new ScenePage("No scene.xml"));
        }
    }

    public class ScenePage : AbstractSingleScenePage
    {
        private readonly string _sceneName;

        public ScenePage(string sceneName)
        {
            _sceneName = sceneName;
            CreateSimpleScene();
        }
    }
}