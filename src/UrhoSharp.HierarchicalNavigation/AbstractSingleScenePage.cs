using System.Collections.Generic;
using Urho;

namespace UrhoSharp.HierarchicalNavigation
{
    public abstract class AbstractSingleScenePage : AbstractScenePage
    {
        private Camera _camera;

        private RenderPath _renderPath;
        private Scene _scene;

        public Scene Scene
        {
            get => _scene;
            set
            {
                if (_scene != value)
                {
                    _scene = value;
                    InvalidateViewports();
                }
            }
        }

        public Camera Camera
        {
            get => _camera;
            set
            {
                if (_camera != value)
                {
                    _camera = value;
                    InvalidateViewports();
                }
            }
        }

        public RenderPath RenderPath
        {
            get => _renderPath;
            set
            {
                if (_renderPath != value)
                {
                    _renderPath = value;
                    InvalidateViewports();
                }
            }
        }

        protected void CreateSimpleScene(float radius = 100.0f)
        {
            CreateSimpleScene(new BoundingBox(new Vector3(-radius, -radius, -radius),
                new Vector3(radius, radius, radius)));
        }

        protected void CreateSimpleScene(BoundingBox bbox)
        {
            Scene = new Scene();
            var octree = Scene.CreateComponent<Octree>();
            octree.SetSize(bbox, 10);
            var z = Scene.CreateComponent<Zone>();
            z.SetBoundingBox(bbox);
            var cameraNode = Scene.CreateChild();
            Camera = cameraNode.CreateComponent<Camera>();
        }

        public override IList<Viewport> GetViewports()
        {
            if (_scene == null || _camera == null)
                return new Viewport[0];
            return new[] {new Viewport(_scene, _camera, _renderPath)};
        }
    }
}