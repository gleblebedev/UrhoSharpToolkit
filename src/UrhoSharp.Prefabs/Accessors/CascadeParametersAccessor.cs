using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class CascadeParametersAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, CascadeParameters>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out CascadeParameters value)
        {
            throw new System.NotImplementedException();
        }
    }
}