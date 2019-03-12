namespace UrhoSharp.Editor.Model
{
    public class PreviewFactory
    {
        public static PreviewFactory Instance { get; } = new PreviewFactory();

        public PreviewFactory()
        {
            Urho.Application.Started += StartPreviewFactory;
        }

        private void StartPreviewFactory()
        {
            
        }
    }
}