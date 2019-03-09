using System.Globalization;
using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class SingleAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, float>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out float value)
        {
            return float.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out value);
        }
    }
}