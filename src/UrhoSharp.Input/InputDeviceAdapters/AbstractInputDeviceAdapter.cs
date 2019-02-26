using System;
using UrhoSharp.Input;

namespace UrhoSharp.Pages.InputDeviceAdapters
{
    public abstract class AbstractInputDeviceAdapter : IInputDeviceAdapter
    {
        public IInputSubscriber Page { get; private set; }

        public virtual void ReleaseSubscriber(IInputSubscriber page)
        {
            if (page != Page)
                throw new InvalidOperationException();
            OnFocusLost();
            Page = null;
        }

        public virtual void AssignSubscriber(IInputSubscriber page)
        {
            Page = page;
        }

        public virtual void OnFocusLost()
        {
        }
    }
}