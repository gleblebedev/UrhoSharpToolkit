using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class TerrainAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Terrain>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out Terrain value)
        {
            throw new System.NotImplementedException();
        }
    }
}