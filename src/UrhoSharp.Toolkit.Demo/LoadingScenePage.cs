using System;
using System.Linq;
using System.Reactive.Concurrency;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Urho;
using Urho.Gui;
using Urho.Resources;
using UrhoSharp.Pages;
using UrhoSharp.Rx;

namespace UrhoSharp.Toolkit.Demo
{
    public class LoadingScenePage : AbstractSingleScenePage, ILoadingProgress
    {
        private readonly Text _text;
        private IUrhoScheduler _scheduler;

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

        private float _angle = 0.0f;
        private Node _animatedNode;

        public void ReportProgress(int index, int count, string message)
        {
            _scheduler.Schedule(() => _text.Value = string.Format("{0}/{1} {2}", index, count, message));
        }

        protected override Task PrepareAsync(IUrhoScheduler scheduler, ILoadingProgress progress)
        {
            _scheduler = scheduler;

            _animatedNode = Scene.CreateChild("WaitAnimation");
            var geometry = EmplyLoadingScenePage.MakeLoadingModel(0.5f);
            _animatedNode.AddComponent(geometry);
            _animatedNode.Position = Vector3.Forward * 2;
            Camera.Node.LookAt(_animatedNode.Position, Vector3.Up);

            return base.PrepareAsync(scheduler, progress);
        }

        public override void Update(float timeStep)
        {
            base.Update(timeStep);

            _animatedNode.Rotation = Quaternion.FromAxisAngle(Vector3.Forward, -_angle);
            _angle += timeStep * 180;
        }

        public override void OnActivated()
        {
            _text.Value = "Loading...";
        }
    }
}