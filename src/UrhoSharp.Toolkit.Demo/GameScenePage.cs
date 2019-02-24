using System;
using System.Threading.Tasks;
using Urho;
using UrhoSharp.HierarchicalNavigation;
using UrhoSharp.Interfaces;
using UrhoSharp.Rx;

namespace UrhoSharp.Toolkit.Demo
{
    public class GameScenePage : AbstractSingleScenePage
    {
        private readonly IScenePage _menuPage;
        private readonly NavigationStack navigation;

        public GameScenePage(NavigationStack navigation, IScenePage menuPage)
        {
            this.navigation = navigation;
            _menuPage = menuPage;
            CreateSimpleScene(100);
            var zone = Scene.GetOrCreateComponent<Zone>();
            zone.FogColor = new Color(0, 0, 1, 1);
        }

        public override MouseMode MouseMode => MouseMode.Absolute;

        public override bool MouseGrabbed => true;

        public override bool MouseVisible => false;

        protected override async Task PrepareAsync(IUrhoScheduler scheduler, ILoadingProgress progress)
        {
            for (int i = 0; i < 40; ++i)
            {
                progress.ReportProgress(i, 40, "Loading game");
                await Task.Delay(TimeSpan.FromSeconds(0.1));
            }
        }

        public override void OnKeyDown(object sender, KeyDownEventArguments args)
        {
            switch (args.Key)
            {
                case Key.Esc:
                    Task.Run(() => navigation.PushAsync(_menuPage));
                    break;
            }

            base.OnKeyDown(sender, args);
        }
    }
}