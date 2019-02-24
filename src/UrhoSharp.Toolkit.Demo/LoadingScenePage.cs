using System;
using System.Reactive.Concurrency;
using System.Threading.Tasks;
using Urho;
using Urho.Gui;
using Urho.Resources;
using UrhoSharp.HierarchicalNavigation;
using UrhoSharp.Interfaces;
using UrhoSharp.Rx;

namespace UrhoSharp.Toolkit.Demo
{
    public class LoadingScenePage : AbstractSingleScenePage, ILoadingProgress
    {
        public LoadingScenePage(ResourceCache cache)
        {
            CreateSimpleScene(100);
            _text = new Text();
            _text.Value = "Loading";
            _text.SetColor(Color.White);
            _text.HorizontalAlignment = HorizontalAlignment.Center;
            _text.VerticalAlignment = VerticalAlignment.Top;
            _text.SetFont(cache.GetFont("Fonts/Anonymous Pro.ttf"), 30);
            UI.AddChild(_text);
        }

        private IUrhoScheduler _scheduler;
        protected override Task PrepareAsync(IUrhoScheduler scheduler, ILoadingProgress progress)
        {
            _scheduler = scheduler;

            return base.PrepareAsync(scheduler, progress);
        }

        public override void Activate(IRenderer renderer)
        {
            base.Activate(renderer);
            _text.Value = "Loading...";
        }

        private Text _text;

        public void ReportProgress(int index, int count, string message)
        {
            _scheduler.Schedule((Action)(() => _text.Value = string.Format("{0}/{1} {2}", index, count, message)));

        }
    }
}