using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class MaterialAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Material>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out Material value)
        {
            throw new System.NotImplementedException();
        }
    }
}