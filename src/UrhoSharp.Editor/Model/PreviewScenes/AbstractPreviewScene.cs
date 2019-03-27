using Urho;
using Urho.Resources;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Editor.Model.PreviewScenes
{
    public abstract class AbstractPreviewScene
    {
        private readonly UrhoRef<Node> _cameraNode = new UrhoRef<Node>();
        private readonly Octree _octree;
        private readonly UrhoRef<Scene> _scene = new UrhoRef<Scene>();

        public AbstractPreviewScene()
        {
            var bbox = new BoundingBox(new Vector3(-1000, -1000, -1000), new Vector3(1000, 1000, 1000));
            _scene.Value = new Scene();
            _octree = Scene.CreateComponent<Octree>();
            _octree.SetSize(bbox, 10);
            Zone = Scene.CreateComponent<Zone>();
            Zone.SetBoundingBox(bbox);
            _cameraNode.Value = new Node();
            Camera = CameraNode.CreateComponent<Camera>();
            Camera.Fov = 45.0f;
            Camera.AspectRatio = 1;
            Camera.AutoAspectRatio = false;
            CameraNode.Position = new Vector3(10, 10, 5);
            CameraNode.LookAt(Vector3.Zero, Vector3.Up);
            PreviewContainer = new Node();
            Scene.AddChild(PreviewContainer);
            Scene.AddChild(CameraNode);
        }

        public ResourceCache ResourceCache => Application.Current.ResourceCache;

        public Scene Scene => _scene.Value;

        public Node CameraNode => _cameraNode.Value;

        public Camera Camera { get; }

        public Node PreviewContainer { get; }

        public Zone Zone { get; }

        protected void UpdateCamera()
        {
            var min = Zone.BoundingBox.Max;
            var max = Zone.BoundingBox.Min;
            foreach (var child in PreviewContainer.Children) AddNode(child, ref min, ref max);

            if (min.X > max.X) return;

            var center = (min + max) * 0.5f;
            var size = max - min;
            CameraNode.Position = center + Vector3.Forward * size.Length * 1.5f + Vector3.Up * size.Length * 0.2f;
            CameraNode.LookAt(center, Vector3.Up);
        }

        private void AddNode(Node node, ref Vector3 min, ref Vector3 max)
        {
            var staticModel = node.GetComponent<StaticModel>();
            if (staticModel != null && staticModel.Model != null)
                AddBBox(staticModel.Model.BoundingBox, node, ref min, ref max);
            var animaModel = node.GetComponent<AnimatedModel>();
            if (animaModel != null && animaModel.Model != null)
                AddBBox(animaModel.Model.BoundingBox, node, ref min, ref max);
            foreach (var child in node.Children) AddNode(child, ref min, ref max);
        }

        private void AddBBox(BoundingBox bbox, Node node, ref Vector3 min, ref Vector3 max)
        {
            var bboxMax = bbox.Max;
            var bboxMin = bbox.Min;
            AddVertex(node.LocalToWorld(bboxMax), ref min, ref max);
            AddVertex(node.LocalToWorld(bboxMin), ref min, ref max);
        }

        private void AddVertex(Vector3 localToWorld, ref Vector3 min, ref Vector3 max)
        {
            if (localToWorld.X < min.X) min.X = localToWorld.X;
            if (localToWorld.X > max.X) max.X = localToWorld.X;
            if (localToWorld.Y < min.Y) min.Y = localToWorld.Y;
            if (localToWorld.Y > max.Y) max.Y = localToWorld.Y;
            if (localToWorld.Z < min.Z) min.Z = localToWorld.Z;
            if (localToWorld.Z > max.Z) max.Z = localToWorld.Z;
        }
    }
}