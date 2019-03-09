using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class BiasParametersAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, BiasParameters>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out BiasParameters value)
        {
            throw new System.NotImplementedException();
        }
    }
}