using UrhoSharp.Input;

namespace UrhoSharp.Pages.InputDeviceAdapters
{
    public interface IInputDeviceAdapter
    {
        void ReleaseSubscriber(IInputSubscriber page);

        void AssignSubscriber(IInputSubscriber page);
        void OnFocusLost();
    }
}