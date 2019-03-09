using Urho;
using Urho.Urho2D;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class Constraint2DAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Constraint2D>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out Constraint2D value)
        {
            throw new System.NotImplementedException();
        }
    }
}