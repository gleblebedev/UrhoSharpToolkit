using System.Collections.Generic;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Input.InputDeviceAdapters
{
    public class TouchAdapter : AbstractInputDeviceAdapter
    {
        private readonly Dictionary<int, TouchEventArguments> _activeTouches =
            new Dictionary<int, TouchEventArguments>();


        public void OnTouchBegin(object sender, TouchBeginEventArguments args)
        {
            if (Page == null)
                return;

            _activeTouches[args.TouchID] = args;

            Page.OnTouchBegin(sender, args);
        }

        public void OnTouchEnd(object sender, TouchEndEventArguments args)
        {
            if (Page == null)
                return;

            if (_activeTouches.ContainsKey(args.TouchID))
            {
                _activeTouches.Remove(args.TouchID);
                Page.OnTouchEnd(sender, args);
            }
        }

        public void OnTouchCancel(object sender, TouchCancelEventArguments args)
        {
            if (Page == null)
                return;

            if (_activeTouches.ContainsKey(args.TouchID))
            {
                _activeTouches.Remove(args.TouchID);
                Page.OnTouchCancel(sender, args);
            }
        }

        public void OnTouchMove(object sender, TouchMoveEventArguments args)
        {
            if (Page == null)
                return;

            if (_activeTouches.ContainsKey(args.TouchID))
            {
                _activeTouches[args.TouchID] = args;
                Page.OnTouchMove(sender, args);
            }
        }


        public override void OnFocusLost()
        {
            if (Page != null)
            {
                foreach (var touch in _activeTouches)
                    Page.OnTouchCancel(this, new TouchCancelEventArguments(touch.Value));
                _activeTouches.Clear();
            }
        }
    }
}