using System.Reactive.Concurrency;
using System.Threading.Tasks;
using Urho;
using Urho.Gui;
using Urho.Resources;
using UrhoSharp.Pages;
using UrhoSharp.Interfaces;
using UrhoSharp.Rx;

namespace UrhoSharp.Toolkit.Demo
{
    public class LoadingScenePage : AbstractSingleScenePage, ILoadingProgress
    {
        private IUrhoScheduler _scheduler;

        private readonly Text _text;

        public LoadingScenePage(ResourceCache cache)
        {
            CreateSimpleScene(100);
            _text = new Text();
            _text.Value = "Loading";
            _text.SetColor(Color.White);
            _text.HorizontalAlignment = HorizontalAlignment.Center;
            _text.VerticalAlignment = VerticalAlignment.Center;
            //_text.SetStyleAuto(null);
            _text.SetFont("Fonts/Anonymous Pro.ttf", 32);
            _text.TextEffect = TextEffect.Stroke;
            UI.AddChild(_text);
        }

        public void ReportProgress(int index, int count, string message)
        {
            _scheduler.Schedule(() => _text.Value = string.Format("{0}/{1} {2}", index, count, message));
        }

        protected override Task PrepareAsync(IUrhoScheduler scheduler, ILoadingProgress progress)
        {
            _scheduler = scheduler;

            return base.PrepareAsync(scheduler, progress);
        }

        public override void OnActivated()
        {
            _text.Value = "Loading...";
        }
    }
}