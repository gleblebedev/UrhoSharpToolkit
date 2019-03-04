using Urho;

namespace UrhoSharp.Prefabs
{
    public class ModelReference : AbstractResourceReference<Model>
    {
        public ModelReference(string resourceName):base(resourceName)
        {
            
        }
        public override void BackgroundLoadResource()
        {
            Application.Current.ResourceCache.BackgroundLoadResource(Model.TypeStatic, ResourceName, false);
        }
        public override Model Create()
        {
            return Application.Current.ResourceCache.GetModel(ResourceName);
        }
    }
}