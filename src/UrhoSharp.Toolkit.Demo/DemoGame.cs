using System.Diagnostics;
using Urho;
using UrhoSharp.Pages;

namespace UrhoSharp.Toolkit.Demo
{
    public class DemoGame : AbstractNavigationApp
    {
        private IScenePage _gamePage;
        private IScenePage _menuPage;

        static DemoGame()
        {
            UnhandledException += (s, e) =>
            {
                if (Debugger.IsAttached)
                    Debugger.Break();
                e.Handled = true;
            };
        }

        [Preserve]
        public DemoGame(ApplicationOptions options) : base(options)
        {
        }

        protected override async void Start()
        {
            base.Start();

#if DEBUG
            var MonoDebugHud = new MonoDebugHud(this);
            MonoDebugHud.Show();
#endif

            UI.Root.SetDefaultStyle(ResourceCache.GetXmlFile("UI/DefaultStyle.xml"));

            await CurrentPageContainer.SetLoadingPageAsync(new LoadingScenePage(ResourceCache));

            _menuPage = new MenuScenePage(Navigation);
            _gamePage = new GameScenePage(Navigation, _menuPage);
            await Navigation.PushAsync(_gamePage);
        }

        protected override void OnUpdate(float timeStep)
        {
            base.OnUpdate(timeStep);
        }
    }
}