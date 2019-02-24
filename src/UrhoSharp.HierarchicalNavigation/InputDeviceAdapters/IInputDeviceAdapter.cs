using System;

namespace UrhoSharp.HierarchicalNavigation.InputDeviceAdapters
{
    public interface IInputDeviceAdapter : IDisposable
    {
        void ReleasePage(IScenePage page);

        void AssignPage(IScenePage page);

        void OnUpdate(float timeStep);
    }
}