using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class ModelAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Model>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out Model value)
        {
            throw new System.NotImplementedException();
        }
    }
}