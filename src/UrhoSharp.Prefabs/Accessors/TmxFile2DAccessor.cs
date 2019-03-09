using Urho;
using Urho.Urho2D;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class TmxFile2DAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, TmxFile2D>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out TmxFile2D value)
        {
            throw new System.NotImplementedException();
        }
    }
}