using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Urho;
using UrhoSharp.Interfaces;
using UrhoSharp.Pages;
using UrhoSharp.Rx;

namespace UrhoSharp.Editor.Model
{
    public class ScenePage : AbstractSingleScenePage
    {
        private readonly bool _isPrefab;
        private readonly string _sceneName;

        public ScenePage(string sceneName, bool isPrefab)
        {
            _sceneName = sceneName;
            _isPrefab = isPrefab;
        }

        protected override async Task PrepareAsync(IUrhoScheduler scheduler, ILoadingProgress progress)
        {
            await scheduler.RunAsync(
                () =>
                {
                    if (_isPrefab)
                        LoadPrefab();
                    else
                        LoadScene();
                    NextInputSubscriber = new FreeCameraController(CameraNode);
                });
        }

        private void LoadScene()
        {
            Scene = new Scene();
            Scene.LoadXml(_sceneName);
            var cameraNode = Scene.GetChildrenWithComponent<Camera>().FirstOrDefault();
            if (cameraNode == null)
                cameraNode = Scene.CreateChild();
            Camera = cameraNode.GetComponent<Camera>();
        }

        private void LoadPrefab()
        {
            var node = new Node();
            node.LoadXml(_sceneName);
            CreateSimpleScene();
            Scene.AddChild(node);
        }

        public override void OnMouseMoved(object sender, MouseMovedEventArguments args)
        {
            base.OnMouseMoved(sender, args);
            var ray = GetScreenRay(args.X, args.Y);
            var res = Scene.GetComponent<Octree>()
                .RaycastSingle(ray, RayQueryLevel.Triangle, 1000, DrawableFlags.Geometry);
            if (res != null)
            {
                var node = res.Value.Node;
                Debug.WriteLine("Select node " + node.ID);
            }
        }

        public override void OnResumed()
        {
            base.OnResumed();
        }
    }
}