using System;
using System.Threading.Tasks;
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

        public void OpenModel(string resourceName)
        {
            Task.Run(() => Navigation.ResetTo(new ModelPage(resourceName)));
        }
    }
}