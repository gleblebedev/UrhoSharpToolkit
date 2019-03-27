using Urho;

namespace UrhoSharp.Editor.Model.PreviewScenes
{
    public class MaterialPreviewScene : AbstractPreviewScene
    {
        private readonly CustomGeometry _model;

        public MaterialPreviewScene()
        {
            _model = PreviewContainer.GetOrCreateComponent<CustomGeometry>();
            //Zone.AmbientColor = Urho.Color.White;
            _model.BeginGeometry(0, PrimitiveType.TriangleList);

            _model.DefineVertex(new Vector3(-1.0f, -1.0f, 0.0f));
            _model.DefineTexCoord(new Vector2(0.0f, 1.0f));
            _model.DefineNormal(new Vector3(0, 0, -1));

            _model.DefineVertex(new Vector3(1.0f, 1.0f, 0.0f));
            _model.DefineTexCoord(new Vector2(1.0f, 0.0f));
            _model.DefineNormal(new Vector3(0, 0, -1));

            _model.DefineVertex(new Vector3(1.0f, -1.0f, 0.0f));
            _model.DefineTexCoord(new Vector2(1.0f, 1.0f));
            _model.DefineNormal(new Vector3(0, 0, -1));


            _model.DefineVertex(new Vector3(-1.0f, -1.0f, 0.0f));
            _model.DefineTexCoord(new Vector2(0.0f, 1.0f));
            _model.DefineNormal(new Vector3(0, 0, -1));

            _model.DefineVertex(new Vector3(-1.0f, 1.0f, 0.0f));
            _model.DefineTexCoord(new Vector2(0.0f, 0.0f));
            _model.DefineNormal(new Vector3(0, 0, -1));

            _model.DefineVertex(new Vector3(1.0f, 1.0f, 0.0f));
            _model.DefineTexCoord(new Vector2(1.0f, 0.0f));
            _model.DefineNormal(new Vector3(0, 0, -1));

            _model.Commit();
            CameraNode.Position = Vector3.Forward * -2 * 1.1708495661125392252006270756823f;
            CameraNode.LookAt(Vector3.Zero, Vector3.Up);
            var lightNode = Scene.CreateChild();
            var light = lightNode.CreateComponent<Light>();
            light.LightType = LightType.Point;
            light.Radius = 4.0f;
            lightNode.Position = CameraNode.Position;
        }

        public void SetMaterial(Material material)
        {
            _model.SetMaterial(material);
        }
    }
}