using Urho;
using Urho.Navigation;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class NavigationMeshAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, NavigationMesh>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out NavigationMesh value)
        {
            throw new System.NotImplementedException();
        }
    }
}