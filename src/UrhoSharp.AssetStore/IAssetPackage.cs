namespace UrhoSharp.AssetStore
{
    public interface IAssetPackage
    {
        string IconUrl { get; }
        string Title { get; }
        string Version { get; }
        string Summary { get; }
        string Description { get; }
    }
}