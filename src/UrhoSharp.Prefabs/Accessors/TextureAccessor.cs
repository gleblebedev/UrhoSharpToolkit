using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class TextureAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Texture>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out Texture value)
        {
            throw new System.NotImplementedException();
        }
    }
}