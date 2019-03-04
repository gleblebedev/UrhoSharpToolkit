namespace UrhoSharp.Prefabs
{
    public abstract class AbstractResourceReference<T>: IPrefab
    {
        private readonly string _resourceName;

        protected AbstractResourceReference(string resourceName)
        {
            _resourceName = resourceName;
        }

        public string ResourceName
        {
            get { return _resourceName; }
        }

        object IPrefab.Create()
        {
            return Create();
        }

        public abstract T Create();

        public abstract void BackgroundLoadResource();
    }
}