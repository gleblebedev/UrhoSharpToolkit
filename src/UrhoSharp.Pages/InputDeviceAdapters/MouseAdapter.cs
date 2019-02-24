using System.Collections.Generic;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Pages.InputDeviceAdapters
{
    public class MouseAdapter : AbstractInputDeviceAdapter
    {
        private readonly Dictionary<int, MouseButtonDownEventArguments> _pressedKeys =
            new Dictionary<int, MouseButtonDownEventArguments>();

        public MouseAdapter(IInput input) : base(input)
        {
            Input.MouseButtonDown += OnMouseButtonDown;
            Input.MouseButtonUp += OnMouseButtonUp;
            Input.MouseModeChanged += OnMouseModeChanged;
            Input.MouseVisibleChanged += OnMouseVisibleChanged;
            Input.MouseMoved += OnMouseMoved;
            Input.MouseWheel += OnMouseWheel;
        }

        private void OnMouseModeChanged(object sender, MouseModeChangedEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnMouseModeChanged(sender, args);
        }

        private void OnMouseVisibleChanged(object sender, MouseVisibleChangedEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnMouseVisibleChanged(sender, args);
        }

        private void OnMouseMoved(object sender, MouseMovedEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnMouseMoved(sender, args);
        }

        private void OnMouseWheel(object sender, MouseWheelEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnMouseWheel(sender, args);
        }

        private void OnMouseButtonUp(object sender, MouseButtonUpEventArguments args)
        {
            if (Page == null)
                return;

            MouseButtonDownEventArguments prevArgs;
            if (!_pressedKeys.TryGetValue(args.Button, out prevArgs))
                return;

            _pressedKeys.Remove(args.Button);
            Page.OnMouseButtonUp(sender, args);
        }

        private void OnMouseButtonDown(object sender, MouseButtonDownEventArguments args)
        {
            if (Page == null)
                return;
            _pressedKeys[args.Button] = args;
            Page.OnMouseButtonDown(sender, args);
        }

        public override void ReleasePage(IScenePage page)
        {
            foreach (var argument in _pressedKeys)
                page.OnMouseButtonCancel(this, new MouseButtonCancelEventArguments(argument.Value));
            _pressedKeys.Clear();
            base.ReleasePage(page);
        }

        public override void Dispose()
        {
            Input.MouseButtonDown -= OnMouseButtonDown;
            Input.MouseButtonUp -= OnMouseButtonUp;
        }
    }
}