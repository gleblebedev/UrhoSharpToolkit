using Urho;

namespace UrhoSharp.Prefabs
{
    public class NodePrefab:IPrefab
    {
        object IPrefab.Create()
        {
            return Create();
        }

        public Node Create()
        {
            var result = new Node();
            return result;
        }
        public void BackgroundLoadResource()
        {
        }
    }
}