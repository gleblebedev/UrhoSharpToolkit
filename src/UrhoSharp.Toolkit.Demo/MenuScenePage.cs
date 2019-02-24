using System;
using System.Threading.Tasks;
using Urho;
using UrhoSharp.Interfaces;
using UrhoSharp.Pages;
using UrhoSharp.Rx;

namespace UrhoSharp.Toolkit.Demo
{
    public class MenuScenePage : AbstractSingleScenePage
    {
        private readonly NavigationStack _navigation;

        public MenuScenePage(NavigationStack navigation)
        {
            _navigation = navigation;
            CreateSimpleScene(100);
            var zone = Scene.GetOrCreateComponent<Zone>();
            zone.FogColor = new Color(0, 1, 0, 1);
            var box = Scene.CreateChild();
            box.Position = new Vector3(0, 0, 4);
            var boxModel = box.CreateComponent<StaticModel>();
            boxModel.Model = ResourceCache.GetModel("Models/Box.mdl");
        }

        protected override async Task PrepareAsync(IUrhoScheduler scheduler, ILoadingProgress progress)
        {
            for (var i = 0; i < 10; ++i)
                //progress.ReportProgress(i,40,"Loading menu");
                await Task.Delay(TimeSpan.FromSeconds(0.1));
        }

        public override void OnKeyDown(object sender, KeyDownEventArguments args)
        {
            switch (args.Key)
            {
                case Key.Esc:
                case Key.Backspace:
                    Task.Run(() => _navigation.GoBackAsync());
                    break;
            }

            base.OnKeyDown(sender, args);
        }

        public override void OnTouchBegin(object sender, TouchBeginEventArguments args)
        {
            base.OnTouchBegin(sender, args);

            Task.Run(() => _navigation.PopAsync());
        }
    }
}