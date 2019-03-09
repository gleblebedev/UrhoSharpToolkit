using System.Globalization;
using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class Int32Accessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, int>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out int value)
        {
            return int.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out value);
        }
    }
}