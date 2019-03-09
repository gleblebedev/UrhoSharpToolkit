using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class Vector2Accessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Vector2>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out Vector2 value)
        {
            throw new System.NotImplementedException();
        }
    }
}