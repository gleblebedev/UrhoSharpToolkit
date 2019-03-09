using Urho;
using Urho.Urho2D;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class RigidBody2DAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, RigidBody2D>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out RigidBody2D value)
        {
            throw new System.NotImplementedException();
        }
    }
}