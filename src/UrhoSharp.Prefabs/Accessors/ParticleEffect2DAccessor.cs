using Urho;
using Urho.Urho2D;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class ParticleEffect2DAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, ParticleEffect2D>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out ParticleEffect2D value)
        {
            throw new System.NotImplementedException();
        }
    }
}