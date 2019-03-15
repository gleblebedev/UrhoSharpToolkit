using Urho;

namespace UrhoSharp.Editor.Model.PreviewScenes
{
    public class ModelPreviewScene : AbstractPreviewScene
    {
        private StaticModel _model;

        public ModelPreviewScene()
        {
            _model = PreviewContainer.GetOrCreateComponent<StaticModel>();
            Zone.AmbientColor = Color.White;
        }
        public void SetModel(Urho.Model model)
        {
            _model.Model = model;
            var size = model.BoundingBox.Size;
            var center = model.BoundingBox.Center;
            CameraNode.Position = Vector3.Forward*size.Length*3.0f +Vector3.Up*size.Y*0.25f + center;
            //CameraNode.Position =  new Vector3(size.X*1.0f, size.Y*1.0f, size.Z*0.5f)+center;
            CameraNode.LookAt(center, Vector3.Up);
        }

    }
}