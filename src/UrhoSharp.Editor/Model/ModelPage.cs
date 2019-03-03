using System.Threading.Tasks;
using Urho;
using UrhoSharp.Pages;
using UrhoSharp.Rx;

namespace UrhoSharp.Editor.Model
{
    public class ModelPage : AbstractSingleScenePage
    {
        private readonly string _modelName;

        public ModelPage(string modelName)
        {
            _modelName = modelName;
        }

        protected override async Task PrepareAsync(IUrhoScheduler scheduler, ILoadingProgress progress)
        {
            await scheduler.RunAsync(
                () => { });
        }

        public override void OnResumed()
        {
            if (Scene == null)
            {
                var mdl = ResourceCache.GetModel(_modelName);
                CreateSimpleScene(mdl.BoundingBox.Size.Length * 4.0f);
                var node = Scene.CreateChild();
                var staticModel = node.CreateComponent<StaticModel>();
                staticModel.Model = mdl;
                var z = Scene.GetOrCreateComponent<Zone>();
                z.FogColor = Color.Blue;
                Camera.Node.Position = mdl.BoundingBox.Size * 2.0f;
                Camera.Node.LookAt(node.Position, Vector3.Up, TransformSpace.World);

                var light = Camera.Node.CreateChild();
                light.Position = Vector3.Up;
                var l = light.CreateComponent<Light>();
                l.Radius = mdl.BoundingBox.Size.Length * 2.0f;
                l.LightType = LightType.Point;
            }

            base.OnResumed();
        }
    }
}