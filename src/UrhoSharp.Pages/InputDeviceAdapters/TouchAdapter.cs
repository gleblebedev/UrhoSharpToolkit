using UrhoSharp.Interfaces;

namespace UrhoSharp.Pages.InputDeviceAdapters
{
    public class TouchAdapter : AbstractInputDeviceAdapter
    {
        public TouchAdapter(IInput input) : base(input)
        {
            Input.TouchBegin += OnTouchBegin;
            Input.TouchEnd += OnTouchEnd;
            Input.TouchMove += OnTouchMove;
        }

        private void OnTouchBegin(object sender, TouchBeginEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnTouchBegin(sender, args);
        }

        private void OnTouchEnd(object sender, TouchEndEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnTouchEnd(sender, args);
        }

        private void OnTouchMove(object sender, TouchMoveEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnTouchMove(sender, args);
        }

        public override void Dispose()
        {
            Input.TouchBegin -= OnTouchBegin;
            Input.TouchEnd -= OnTouchEnd;
            Input.TouchMove -= OnTouchMove;
        }
    }
}