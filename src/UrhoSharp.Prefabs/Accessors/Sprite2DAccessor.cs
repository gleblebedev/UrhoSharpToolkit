using Urho;
using Urho.Urho2D;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class Sprite2DAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Sprite2D>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out Sprite2D value)
        {
            throw new System.NotImplementedException();
        }
    }
}