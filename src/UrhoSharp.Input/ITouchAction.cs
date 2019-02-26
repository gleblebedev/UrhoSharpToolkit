namespace UrhoSharp.Input
{
    public interface ITouchAction
    {
        void Start(TouchArgs args);
        void Update(TouchArgs args);
        void Complete(TouchArgs args);
        void Cancel();
    }
}