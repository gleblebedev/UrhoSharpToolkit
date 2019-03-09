using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class ColorAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Color>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out Color value)
        {
            throw new System.NotImplementedException();
        }
    }
}