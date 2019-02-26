using System.Collections.Generic;
using UrhoSharp.Interfaces;
using UrhoSharp.Pages.InputDeviceAdapters;

namespace UrhoSharp.Input
{
    public class InputDispatcher : IInputSubscriber
    {
        private readonly JoystickAdapter _joysticks;
        private readonly KeyboardAdapter _keyboard;
        private readonly MouseAdapter _mouse;
        private readonly TouchAdapter _touch;

        private IInputSubscriber _subscriber;

        public InputDispatcher()
        {
            _keyboard = new KeyboardAdapter();
            _mouse = new MouseAdapter();
            _joysticks = new JoystickAdapter();
            _touch = new TouchAdapter();
        }

        public IInputSubscriber Subscriber
        {
            get => _subscriber;
            set
            {
                if (_subscriber != value)
                {
                    ReleaseSubscriber();
                    _subscriber = value;
                    AssignSubscriber();
                }
            }
        }


        public void OnKeyCancel(object sender, KeyCancelEventArguments args)
        {
            _keyboard.OnKeyCancel(sender, args);
        }

        public void OnKeyDown(object sender, KeyDownEventArguments args)
        {
            _keyboard.OnKeyDown(sender, args);
        }

        public void OnKeyUp(object sender, KeyUpEventArguments args)
        {
            _keyboard.OnKeyUp(sender, args);
        }

        public void OnMouseButtonCancel(object sender, MouseButtonCancelEventArguments args)
        {
            _mouse.OnMouseButtonCancel(sender, args);
        }

        public void OnMouseButtonDown(object sender, MouseButtonDownEventArguments args)
        {
            _mouse.OnMouseButtonDown(sender, args);
        }

        public void OnMouseButtonUp(object sender, MouseButtonUpEventArguments args)
        {
            _mouse.OnMouseButtonUp(sender, args);
        }

        public void OnMouseMoved(object sender, MouseMovedEventArguments args)
        {
            _mouse.OnMouseMoved(sender, args);
        }

        public void OnMouseWheel(object sender, MouseWheelEventArguments args)
        {
            _mouse.OnMouseWheel(sender, args);
        }

        public void OnMouseVisibleChanged(object sender, MouseVisibleChangedEventArguments args)
        {
            _subscriber?.OnMouseVisibleChanged(sender, args);
        }

        public void OnMouseModeChanged(object sender, MouseModeChangedEventArguments args)
        {
            _subscriber?.OnMouseModeChanged(sender, args);
        }

        public void OnTextInput(object sender, TextInputEventArguments args)
        {
            _subscriber?.OnTextInput(sender, args);
        }

        public void OnJoystickConnected(object sender, JoystickConnectedEventArguments args)
        {
            _joysticks.OnJoystickConnected(sender, args);
        }

        public void OnJoystickDisconnected(object sender, JoystickDisconnectedEventArguments args)
        {
            _joysticks.OnJoystickDisconnected(sender, args);
        }

        public void OnJoystickButtonDown(object sender, JoystickButtonDownEventArguments args)
        {
            _joysticks.OnJoystickButtonDown(sender, args);
        }

        public void OnJoystickButtonUp(object sender, JoystickButtonUpEventArguments args)
        {
            _joysticks.OnJoystickButtonUp(sender, args);
        }

        public void OnJoystickButtonCancel(object sender, JoystickButtonCancelEventArguments args)
        {
            _joysticks.OnJoystickButtonCancel(sender, args);
        }

        public void OnJoystickAxisMove(object sender, JoystickAxisMoveEventArguments args)
        {
            _joysticks.OnJoystickAxisMove(sender, args);
        }

        public void OnJoystickHatMove(object sender, JoystickHatMoveEventArguments args)
        {
            _joysticks.OnJoystickHatMove(sender, args);
        }

        public void OnTouchBegin(object sender, TouchBeginEventArguments args)
        {
            _touch.OnTouchBegin(sender, args);
        }

        public void OnTouchEnd(object sender, TouchEndEventArguments args)
        {
            _touch.OnTouchEnd(sender, args);
        }

        public void OnTouchMove(object sender, TouchMoveEventArguments args)
        {
            _touch.OnTouchMove(sender, args);
        }

        public void OnTouchCancel(object sender, TouchCancelEventArguments args)
        {
            _touch.OnTouchCancel(sender, args);
        }

        public void OnGestureRecorded(object sender, GestureRecordedEventArguments args)
        {
            _subscriber?.OnGestureRecorded(sender, args);
        }

        public void OnGestureInput(object sender, GestureInputEventArguments args)
        {
            _subscriber?.OnGestureInput(sender, args);
        }

        public void OnMultiGesture(object sender, MultiGestureEventArguments args)
        {
            _subscriber?.OnMultiGesture(sender, args);
        }

        public void OnDropFile(object sender, DropFileEventArguments args)
        {
            _subscriber?.OnDropFile(sender, args);
        }

        public void OnInputFocus(object sender, InputFocusEventArguments args)
        {
            if (!args.Focus)
                foreach (var adapter in GetInputDeviceAdapters())
                    adapter.OnFocusLost();
            _subscriber?.OnInputFocus(sender, args);
        }

        public void OnExitRequested(object sender, ExitRequestedEventArguments args)
        {
            _subscriber?.OnExitRequested(sender, args);
        }

        private void ReleaseSubscriber()
        {
            if (_subscriber == null)
                return;
            foreach (var adapter in GetInputDeviceAdapters()) adapter.ReleaseSubscriber(_subscriber);
        }

        private void AssignSubscriber()
        {
            if (_subscriber == null)
                return;
            foreach (var adapter in GetInputDeviceAdapters()) adapter.AssignSubscriber(_subscriber);
        }

        private IEnumerable<IInputDeviceAdapter> GetInputDeviceAdapters()
        {
            yield return _keyboard;
            yield return _mouse;
            yield return _joysticks;
            yield return _touch;
        }
    }
}