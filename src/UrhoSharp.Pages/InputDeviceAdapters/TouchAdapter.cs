using System.Collections.Generic;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Pages.InputDeviceAdapters
{
    public class TouchAdapter : AbstractInputDeviceAdapter
    {
        private readonly Dictionary<int, TouchEventArguments> _activeTouches =
            new Dictionary<int, TouchEventArguments>();

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

            _activeTouches[args.TouchID] = args;

            Page.OnTouchBegin(sender, args);
        }

        private void OnTouchEnd(object sender, TouchEndEventArguments args)
        {
            if (Page == null)
                return;

            if (_activeTouches.ContainsKey(args.TouchID))
            {
                _activeTouches.Remove(args.TouchID);
                Page.OnTouchEnd(sender, args);
            }
        }

        private void OnTouchMove(object sender, TouchMoveEventArguments args)
        {
            if (Page == null)
                return;

            if (_activeTouches.ContainsKey(args.TouchID))
            {
                _activeTouches[args.TouchID] = args;
                Page.OnTouchMove(sender, args);
            }
        }

        public override void ReleasePage(IScenePage page)
        {
            foreach (var touch in _activeTouches) page.OnTouchCancel(this, new TouchCancelEventArguments(touch.Value));
            _activeTouches.Clear();
            base.ReleasePage(page);
        }

        public override void Dispose()
        {
            Input.TouchBegin -= OnTouchBegin;
            Input.TouchEnd -= OnTouchEnd;
            Input.TouchMove -= OnTouchMove;
        }
    }
}