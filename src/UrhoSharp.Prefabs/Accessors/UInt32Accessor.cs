using System.Globalization;
using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class UInt32Accessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, uint>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out uint value)
        {
            return uint.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out value);
        }
    }
}