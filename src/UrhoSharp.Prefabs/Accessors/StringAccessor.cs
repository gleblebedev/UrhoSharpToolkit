using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class StringAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, string>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out string value)
        {
            value = text;
            return true;
        }
    }
}