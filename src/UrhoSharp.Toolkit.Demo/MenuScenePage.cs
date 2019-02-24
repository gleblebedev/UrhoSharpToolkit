using System;
using System.Threading.Tasks;
using Urho;
using UrhoSharp.HierarchicalNavigation;
using UrhoSharp.Interfaces;
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
        }

        protected override async Task PrepareAsync(IUrhoScheduler scheduler, ILoadingProgress progress)
        {
            for (int i = 0; i < 40; ++i)
            {
                //progress.ReportProgress(i,40,"Loading menu");
                await Task.Delay(TimeSpan.FromSeconds(0.1));
            }
        }

        public override void OnKeyDown(object sender, KeyDownEventArguments args)
        {
            switch (args.Key)
            {
                case Key.Esc:
                    Task.Run(() => _navigation.PopAsync());
                    break;
            }

            base.OnKeyDown(sender, args);
        }
    }
}