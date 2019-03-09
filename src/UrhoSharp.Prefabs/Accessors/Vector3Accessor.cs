using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class Vector3Accessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Vector3>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out Vector3 value)
        {
            throw new System.NotImplementedException();
        }
    }
}