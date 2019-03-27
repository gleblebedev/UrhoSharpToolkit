using System;

namespace UrhoSharp.Input.InputDeviceAdapters
{
    public abstract class AbstractInputDeviceAdapter : IInputDeviceAdapter
    {
        public IInputSubscriber Page { get; private set; }

        public virtual void ReleaseSubscriber(IInputSubscriber inputSubscriber)
        {
            if (inputSubscriber != Page)
                throw new InvalidOperationException();
            OnFocusLost();
            Page = null;
        }

        public virtual void AssignSubscriber(IInputSubscriber inputSubscriber)
        {
            Page = inputSubscriber;
        }

        public virtual void OnFocusLost()
        {
        }
    }
}