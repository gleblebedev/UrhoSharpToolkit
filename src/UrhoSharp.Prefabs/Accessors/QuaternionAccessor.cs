using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class QuaternionAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Quaternion>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out Quaternion value)
        {
            throw new System.NotImplementedException();
        }
    }
}