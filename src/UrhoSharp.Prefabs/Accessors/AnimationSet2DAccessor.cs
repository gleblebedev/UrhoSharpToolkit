using Urho;
using Urho.Urho2D;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class AnimationSet2DAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, AnimationSet2D>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out AnimationSet2D value)
        {
            throw new System.NotImplementedException();
        }
    }
}