using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class IntVector2Accessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, IntVector2>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out IntVector2 value)
        {
            throw new System.NotImplementedException();
        }
    }
}