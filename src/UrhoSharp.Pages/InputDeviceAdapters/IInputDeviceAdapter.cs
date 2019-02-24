using System;

namespace UrhoSharp.Pages.InputDeviceAdapters
{
    public interface IInputDeviceAdapter : IDisposable
    {
        void ReleasePage(IScenePage page);

        void AssignPage(IScenePage page);

        void OnUpdate(float timeStep);
    }
}