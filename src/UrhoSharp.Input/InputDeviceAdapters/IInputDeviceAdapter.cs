namespace UrhoSharp.Input.InputDeviceAdapters
{
    public interface IInputDeviceAdapter
    {
        void ReleaseSubscriber(IInputSubscriber page);

        void AssignSubscriber(IInputSubscriber page);
        void OnFocusLost();
    }
}