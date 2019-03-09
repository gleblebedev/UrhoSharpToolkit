using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class BooleanAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, bool>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out bool value)
        {
            return bool.TryParse(text, out value);
        }
    }
}