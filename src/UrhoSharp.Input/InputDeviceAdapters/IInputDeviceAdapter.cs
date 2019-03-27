namespace UrhoSharp.Input.InputDeviceAdapters
{
    public interface IInputDeviceAdapter
    {
        void ReleaseSubscriber(IInputSubscriber inputSubscriber);

        void AssignSubscriber(IInputSubscriber inputSubscriber);
        void OnFocusLost();
    }
}