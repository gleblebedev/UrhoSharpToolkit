namespace UrhoSharp.Editor.Model
{
    public interface IConfigurationContainer<T>
    {
        T Value { get; }
        void Save();
    }
}