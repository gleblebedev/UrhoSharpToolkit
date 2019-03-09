using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class ParticleEffectAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, ParticleEffect>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out ParticleEffect value)
        {
            throw new System.NotImplementedException();
        }
    }
}