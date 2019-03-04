using System.Linq;
using System.Threading.Tasks;
using Urho;
using Urho.IO;
using UrhoSharp.Pages;
using UrhoSharp.Rx;

namespace UrhoSharp.Editor.Model
{
    public class ScenePage : AbstractSingleScenePage
    {
        private readonly string _sceneName;
        private readonly bool _isPrefab;

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
        public override void OnResumed()
        {
            base.OnResumed();
        }
    }
}