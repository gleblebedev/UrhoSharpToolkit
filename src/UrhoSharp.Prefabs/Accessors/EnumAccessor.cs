using System;
using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class EnumAccessor<TPrefab, TUrho, TEnum> : AbstractAccessor<TPrefab, TUrho, TEnum> where TEnum : struct
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out TEnum value)
        {
            return Enum.TryParse<TEnum>(text, true, out value);
        }
    }
}