using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class PlaneAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Plane>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out Plane value)
        {
            throw new System.NotImplementedException();
        }
    }
}