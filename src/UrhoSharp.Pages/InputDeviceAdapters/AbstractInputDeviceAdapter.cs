using UrhoSharp.Interfaces;

namespace UrhoSharp.Pages.InputDeviceAdapters
{
    public abstract class AbstractInputDeviceAdapter : IInputDeviceAdapter
    {
        protected AbstractInputDeviceAdapter(IInput input)
        {
            Input = input;
        }

        public IInput Input { get; }

        public IScenePage Page { get; private set; }

        public abstract void Dispose();

        public virtual void ReleasePage(IScenePage page)
        {
            Page = null;
        }

        public virtual void AssignPage(IScenePage page)
        {
            Page = page;
        }

        public virtual void OnUpdate(float timeStep)
        {
        }
    }
}