using System;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Input
{
    public class InputProxy : IDisposable
    {
        private readonly IInput _input;
        private readonly IInputSubscriber _subscriber;

        public InputProxy(IInput input, IInputSubscriber subscriber)
        {
            _input = input;
            _subscriber = subscriber;

            _input.TouchBegin += OnTouchBegin;
            _input.TouchEnd += OnTouchEnd;
            _input.TouchMove += OnTouchMove;
            _input.MouseButtonDown += OnMouseButtonDown;
            _input.MouseButtonUp += OnMouseButtonUp;
            _input.MouseModeChanged += OnMouseModeChanged;
            _input.MouseVisibleChanged += OnMouseVisibleChanged;
            _input.MouseMoved += OnMouseMoved;
            _input.MouseWheel += OnMouseWheel;
            _input.KeyDown += OnKeyDown;
            _input.KeyUp += OnKeyUp;
            _input.JoystickAxisMove += OnJoystickAxisMove;
            _input.JoystickButtonDown += OnJoystickButtonDown;
            _input.JoystickButtonUp += OnJoystickButtonUp;
            _input.JoystickConnected += OnJoystickConnected;
            _input.JoystickDisconnected += OnJoystickDisconnected;
            _input.JoystickHatMove += OnJoystickHatMove;
            _input.TextInput += OnTextInput;

            _input.GestureRecorded += OnGestureRecorded;
            _input.GestureInput += OnGestureInput;
            _input.MultiGesture += OnMultiGesture;
            _input.DropFile += OnDropFile;
            _input.InputFocus += OnInputFocus;
            _input.ExitRequested += OnExitRequested;
        }

        public void Dispose()
        {
            _input.TouchBegin -= OnTouchBegin;
            _input.TouchEnd -= OnTouchEnd;
            _input.TouchMove -= OnTouchMove;
            _input.MouseButtonDown -= OnMouseButtonDown;
            _input.MouseButtonUp -= OnMouseButtonUp;
            _input.MouseModeChanged -= OnMouseModeChanged;
            _input.MouseVisibleChanged -= OnMouseVisibleChanged;
            _input.MouseMoved -= OnMouseMoved;
            _input.MouseWheel -= OnMouseWheel;
            _input.KeyDown -= OnKeyDown;
            _input.KeyUp -= OnKeyUp;
            _input.JoystickAxisMove -= OnJoystickAxisMove;
            _input.JoystickButtonDown -= OnJoystickButtonDown;
            _input.JoystickButtonUp -= OnJoystickButtonUp;
            _input.JoystickConnected -= OnJoystickConnected;
            _input.JoystickDisconnected -= OnJoystickDisconnected;
            _input.JoystickHatMove -= OnJoystickHatMove;
            _input.TextInput -= OnTextInput;

            _input.GestureRecorded -= OnGestureRecorded;
            _input.GestureInput -= OnGestureInput;
            _input.MultiGesture -= OnMultiGesture;
            _input.DropFile -= OnDropFile;
            _input.InputFocus -= OnInputFocus;
            _input.ExitRequested -= OnExitRequested;
        }

        private void OnKeyDown(object sender, KeyDownEventArguments args)
        {
            _subscriber.OnKeyDown(sender, args);
        }

        private void OnKeyUp(object sender, KeyUpEventArguments args)
        {
            _subscriber.OnKeyUp(sender, args);
        }

        private void OnMouseButtonDown(object sender, MouseButtonDownEventArguments args)
        {
            _subscriber.OnMouseButtonDown(sender, args);
        }

        private void OnMouseButtonUp(object sender, MouseButtonUpEventArguments args)
        {
            _subscriber.OnMouseButtonUp(sender, args);
        }

        private void OnMouseMoved(object sender, MouseMovedEventArguments args)
        {
            _subscriber.OnMouseMoved(sender, args);
        }

        private void OnMouseWheel(object sender, MouseWheelEventArguments args)
        {
            _subscriber.OnMouseWheel(sender, args);
        }

        private void OnMouseVisibleChanged(object sender, MouseVisibleChangedEventArguments args)
        {
            _subscriber.OnMouseVisibleChanged(sender, args);
        }

        private void OnMouseModeChanged(object sender, MouseModeChangedEventArguments args)
        {
            _subscriber.OnMouseModeChanged(sender, args);
        }

        private void OnTextInput(object sender, TextInputEventArguments args)
        {
            _subscriber.OnTextInput(sender, args);
        }

        private void OnJoystickConnected(object sender, JoystickConnectedEventArguments args)
        {
            _subscriber.OnJoystickConnected(sender, args);
        }

        private void OnJoystickDisconnected(object sender, JoystickDisconnectedEventArguments args)
        {
            _subscriber.OnJoystickDisconnected(sender, args);
        }

        private void OnJoystickButtonDown(object sender, JoystickButtonDownEventArguments args)
        {
            _subscriber.OnJoystickButtonDown(sender, args);
        }

        private void OnJoystickButtonUp(object sender, JoystickButtonUpEventArguments args)
        {
            _subscriber.OnJoystickButtonUp(sender, args);
        }

        private void OnJoystickAxisMove(object sender, JoystickAxisMoveEventArguments args)
        {
            _subscriber.OnJoystickAxisMove(sender, args);
        }

        private void OnJoystickHatMove(object sender, JoystickHatMoveEventArguments args)
        {
            _subscriber.OnJoystickHatMove(sender, args);
        }

        private void OnTouchBegin(object sender, TouchBeginEventArguments args)
        {
            _subscriber.OnTouchBegin(sender, args);
        }

        private void OnTouchEnd(object sender, TouchEndEventArguments args)
        {
            _subscriber.OnTouchEnd(sender, args);
        }

        private void OnTouchMove(object sender, TouchMoveEventArguments args)
        {
            _subscriber.OnTouchMove(sender, args);
        }

        private void OnGestureRecorded(object sender, GestureRecordedEventArguments args)
        {
            _subscriber.OnGestureRecorded(sender, args);
        }

        private void OnGestureInput(object sender, GestureInputEventArguments args)
        {
            _subscriber.OnGestureInput(sender, args);
        }

        private void OnMultiGesture(object sender, MultiGestureEventArguments args)
        {
            _subscriber.OnMultiGesture(sender, args);
        }

        private void OnDropFile(object sender, DropFileEventArguments args)
        {
            _subscriber.OnDropFile(sender, args);
        }

        private void OnInputFocus(object sender, InputFocusEventArguments args)
        {
            _subscriber.OnInputFocus(sender, args);
        }

        private void OnExitRequested(object sender, ExitRequestedEventArguments args)
        {
            _subscriber.OnExitRequested(sender, args);
        }
    }
}