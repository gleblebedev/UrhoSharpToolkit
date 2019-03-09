using Urho;
using Urho.Physics;
using Urho.Urho2D;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class RigidBodyAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, RigidBody>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out RigidBody value)
        {
            throw new System.NotImplementedException();
        }
    }
}