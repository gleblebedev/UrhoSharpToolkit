using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class NodeAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Node>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out Node value)
        {
            throw new System.NotImplementedException();
        }
    }
}