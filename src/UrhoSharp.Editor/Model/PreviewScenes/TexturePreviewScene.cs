using Urho;
using Urho.Urho2D;

namespace UrhoSharp.Editor.Model.PreviewScenes
{
    public class TexturePreviewScene : AbstractPreviewScene
    {
        private readonly Material _material;
        private readonly CustomGeometry _model;

        public TexturePreviewScene()
        {
            _model = PreviewContainer.GetOrCreateComponent<CustomGeometry>();
            Zone.AmbientColor = Color.White;
            _material = new Material();
            _material.SetTechnique(0, ResourceCache.GetTechnique("Techniques/DiffUnlit.xml"), 1, 1);
            _model.BeginGeometry(0, PrimitiveType.TriangleList);

            _model.DefineVertex(new Vector3(-1.0f, -1.0f, 0.0f));
            _model.DefineTexCoord(new Vector2(0.0f, 1.0f));
            _model.DefineVertex(new Vector3(1.0f, 1.0f, 0.0f));
            _model.DefineTexCoord(new Vector2(1.0f, 0.0f));
            _model.DefineVertex(new Vector3(1.0f, -1.0f, 0.0f));
            _model.DefineTexCoord(new Vector2(1.0f, 1.0f));


            _model.DefineVertex(new Vector3(-1.0f, -1.0f, 0.0f));
            _model.DefineTexCoord(new Vector2(0.0f, 1.0f));
            _model.DefineVertex(new Vector3(-1.0f, 1.0f, 0.0f));
            _model.DefineTexCoord(new Vector2(0.0f, 0.0f));
            _model.DefineVertex(new Vector3(1.0f, 1.0f, 0.0f));
            _model.DefineTexCoord(new Vector2(1.0f, 0.0f));

            _model.Commit();
            _model.SetMaterial(_material);
            CameraNode.Position = Vector3.Forward * -2 * 1.1708495661125392252006270756823f;
            CameraNode.LookAt(Vector3.Zero, Vector3.Up);
        }

        public void SetTexture(Texture2D texture)
        {
            _material.SetTexture(TextureUnit.Diffuse, texture);
        }
    }
}