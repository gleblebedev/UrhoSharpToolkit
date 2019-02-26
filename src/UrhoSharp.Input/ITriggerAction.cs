namespace UrhoSharp.Input
{
    public interface ITriggerAction
    {
        void StartOrUpdate(float value);
        void Stop();
        void Cancel();
    }
}