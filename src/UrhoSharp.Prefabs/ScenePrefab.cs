using Urho;

namespace UrhoSharp.Prefabs
{
    public class ScenePrefab: NodePrefab
    {
        public ScenePrefab(Scene scene):base(scene)
        {
        }

  

        public override Node Create()
        {
            var result = new Scene();
            return result;
        }


    }
}