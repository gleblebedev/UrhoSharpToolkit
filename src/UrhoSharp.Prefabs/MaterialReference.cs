using Urho;

namespace UrhoSharp.Prefabs
{
    public class MaterialReference: AbstractResourceReference<Material>
    {
        public MaterialReference(string resourceName) : base(resourceName)
        {
        }
        public override void BackgroundLoadResource()
        {
            Application.Current.ResourceCache.BackgroundLoadResource(Material.TypeStatic, ResourceName, false);
        }

        public override Material Create()
        {
            return Urho.Application.Current.ResourceCache.GetMaterial(ResourceName);
        }
    }
}