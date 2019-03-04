namespace UrhoSharp.Prefabs
{
    public interface IPrefab
    {
        void BackgroundLoadResource();

        object Create();
    }
}