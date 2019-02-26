using System.Collections.Generic;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Pages.InputDeviceAdapters
{
    public class MouseAdapter : AbstractInputDeviceAdapter
    {
        private readonly Dictionary<int, MouseButtonDownEventArguments> _pressedKeys =
            new Dictionary<int, MouseButtonDownEventArguments>();

        public void OnMouseMoved(object sender, MouseMovedEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnMouseMoved(sender, args);
        }

        public void OnMouseWheel(object sender, MouseWheelEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnMouseWheel(sender, args);
        }

        public void OnMouseButtonUp(object sender, MouseButtonUpEventArguments args)
        {
            if (Page == null)
                return;

            MouseButtonDownEventArguments prevArgs;
            if (!_pressedKeys.TryGetValue(args.Button, out prevArgs))
                return;

            _pressedKeys.Remove(args.Button);
            Page.OnMouseButtonUp(sender, args);
        }

        public void OnMouseButtonCancel(object sender, MouseButtonCancelEventArguments args)
        {
            if (Page == null)
                return;

            MouseButtonDownEventArguments prevArgs;
            if (!_pressedKeys.TryGetValue(args.Button, out prevArgs))
                return;

            _pressedKeys.Remove(args.Button);
            Page.OnMouseButtonCancel(sender, args);
        }

        public void OnMouseButtonDown(object sender, MouseButtonDownEventArguments args)
        {
            if (Page == null)
                return;
            _pressedKeys[args.Button] = args;
            Page.OnMouseButtonDown(sender, args);
        }

        public override void OnFocusLost()
        {
            if (Page != null)
            {
                foreach (var argument in _pressedKeys)
                    Page.OnMouseButtonCancel(this, new MouseButtonCancelEventArguments(argument.Value));
                _pressedKeys.Clear();
            }
        }
    }
}