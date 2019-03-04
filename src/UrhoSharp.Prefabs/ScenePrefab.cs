using Urho;

namespace UrhoSharp.Prefabs
{
    public class ScenePrefab:IPrefab
    {
        object IPrefab.Create()
        {
            return Create();
        }

        public Scene Create()
        {
            var result = new Scene();
            return result;
        }
        public void BackgroundLoadResource()
        {
        }
    }
}