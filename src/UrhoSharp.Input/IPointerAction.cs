namespace UrhoSharp.Input
{
    public interface IPointerAction
    {
        void StartOrUpdate(PointerArgs value);
        void Cancel();
    }
}