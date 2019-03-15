using System;
using System.Diagnostics;
using Urho;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Editor.Model.PreviewScenes
{
    public class PrefabPreviewScene : AbstractPreviewScene
    {
        private UrhoRef<Node> _lightNode;
        public PrefabPreviewScene()
        {
            Zone.AmbientColor = new Color(0.5f, 0.5f, 0.5f, 1.0f);
            var lightNode = Scene.CreateChild();
            _lightNode = new UrhoRef<Node>(lightNode);
            var dir = (Vector3.Down + Vector3.Back);
            dir.Normalize();
            lightNode.SetDirection(dir);
            Light light = lightNode.CreateComponent<Light>();
            light.LightType = LightType.Directional;
            light.Color = new Color(0.5f, 0.5f, 0.5f, 1.0f);
            light.FadeDistance = 1000.0f;
            light.SpecularIntensity = 1.0f;

            lightNode.LookAt(Vector3.Zero, Vector3.Up);
        }
        public void SetPrefab(string name)
        {
            PreviewContainer.RemoveAllChildren();
            try
            {
                var node = new Node();
                node.LoadXml(name);
                PreviewContainer.AddChild(node);
                UpdateCamera();
                Scene.RemoveChild(_lightNode.Value);
                _lightNode.Value.Position = CameraNode.Position;
                Scene.AddChild(_lightNode.Value);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }
    }
}