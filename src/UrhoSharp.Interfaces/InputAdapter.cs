using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class InputAdapter : IInput, IDisposable
    {
        private readonly Input _input;

        public InputAdapter(Input input)
        {
            _input = input;
        }

        public void Dispose()
        {
            _input.KeyUp -= OnKeyUp;
            _input.KeyDown -= OnKeyDown;
            _input.TouchBegin -= OnTouchBegin;
            _input.TouchEnd -= OnTouchEnd;
            _input.TouchMove -= OnTouchMove;
            _input.TextInput -= OnTextInput;
            _input.MouseButtonDown -= OnMouseButtonDown;
            _input.MouseButtonUp -= OnMouseButtonUp;
            _input.MouseModeChanged -= OnMouseModeChanged;
            _input.MouseWheel -= OnMouseWheel;
            _input.MouseMoved -= OnMouseMoved;
            _input.MultiGesture -= OnMultiGesture;

            _input.TextInput -= OnTextInput;
            _input.JoystickConnected -= OnJoystickConnected;
            _input.JoystickDisconnected -= OnJoystickDisconnected;
            _input.JoystickButtonDown -= OnJoystickButtonDown;
            _input.JoystickButtonUp -= OnJoystickButtonUp;
            _input.JoystickAxisMove -= OnJoystickAxisMove;
            _input.JoystickHatMove -= OnJoystickHatMove;
            _input.GestureRecorded -= OnGestureRecorded;
            _input.GestureInput -= OnGestureInput;

            _input.DropFile -= OnDropFile;
            _input.InputFocus -= OnInputFocus;
            _input.MouseVisibleChanged -= OnMouseVisibleChanged;
            _input.ExitRequested -= OnExitRequested;
        }

        #region Keys

        private EventHandler<KeyDownEventArguments> _keyDown;

        private EventHandler<KeyUpEventArguments> _keyUp;

        public event EventHandler<KeyUpEventArguments> KeyUp
        {
            add
            {
                if (_keyUp == null)
                    _input.KeyUp += OnKeyUp;
                _keyUp += value;
            }
            remove
            {
                _keyUp -= value;
                if (_keyUp == null)
                    _input.KeyUp -= OnKeyUp;
            }
        }

        public event EventHandler<KeyDownEventArguments> KeyDown
        {
            add
            {
                if (_keyDown == null)
                    _input.KeyDown += OnKeyDown;
                _keyDown += value;
            }
            remove
            {
                _keyDown -= value;
                if (_keyDown == null)
                    _input.KeyDown -= OnKeyDown;
            }
        }

        private void OnKeyUp(KeyUpEventArgs args)
        {
            _keyUp?.Invoke(this, new KeyUpEventArguments(args));
        }

        private void OnKeyDown(KeyDownEventArgs args)
        {
            _keyDown?.Invoke(this, new KeyDownEventArguments(args));
        }

        #endregion

        #region Mouse

        private EventHandler<MouseVisibleChangedEventArguments> _mouseVisibleChanged;

        public event EventHandler<MouseVisibleChangedEventArguments> MouseVisibleChanged
        {
            add
            {
                if (_mouseVisibleChanged == null)
                    _input.MouseVisibleChanged += OnMouseVisibleChanged;
                _mouseVisibleChanged += value;
            }
            remove
            {
                _mouseVisibleChanged -= value;
                if (_mouseVisibleChanged == null)
                    _input.MouseVisibleChanged -= OnMouseVisibleChanged;
            }
        }

        private void OnMouseVisibleChanged(MouseVisibleChangedEventArgs args)
        {
            _mouseVisibleChanged?.Invoke(this, new MouseVisibleChangedEventArguments(args));
        }

        private EventHandler<MouseModeChangedEventArguments> _mouseModeChanged;

        public event EventHandler<MouseModeChangedEventArguments> MouseModeChanged
        {
            add
            {
                if (_mouseModeChanged == null)
                    _input.MouseModeChanged += OnMouseModeChanged;
                _mouseModeChanged += value;
            }
            remove
            {
                _mouseModeChanged -= value;
                if (_mouseModeChanged == null)
                    _input.MouseModeChanged -= OnMouseModeChanged;
            }
        }

        private void OnMouseModeChanged(MouseModeChangedEventArgs args)
        {
            _mouseModeChanged?.Invoke(this, new MouseModeChangedEventArguments(args));
        }

        private EventHandler<MouseButtonDownEventArguments> _mouseButtonDown;

        private EventHandler<MouseButtonUpEventArguments> _mouseButtonUp;

        public event EventHandler<MouseButtonUpEventArguments> MouseButtonUp
        {
            add
            {
                if (_mouseButtonUp == null)
                    _input.MouseButtonUp += OnMouseButtonUp;
                _mouseButtonUp += value;
            }
            remove
            {
                _mouseButtonUp -= value;
                if (_mouseButtonUp == null)
                    _input.MouseButtonUp -= OnMouseButtonUp;
            }
        }

        public event EventHandler<MouseButtonDownEventArguments> MouseButtonDown
        {
            add
            {
                if (_mouseButtonDown == null)
                    _input.MouseButtonDown += OnMouseButtonDown;
                _mouseButtonDown += value;
            }
            remove
            {
                _mouseButtonDown -= value;
                if (_mouseButtonDown == null)
                    _input.MouseButtonDown -= OnMouseButtonDown;
            }
        }

        private void OnMouseButtonUp(MouseButtonUpEventArgs args)
        {
            _mouseButtonUp?.Invoke(this, new MouseButtonUpEventArguments(args));
        }

        private void OnMouseButtonDown(MouseButtonDownEventArgs args)
        {
            _mouseButtonDown?.Invoke(this, new MouseButtonDownEventArguments(args));
        }

        private EventHandler<MouseMovedEventArguments> _mouseMoved;

        public event EventHandler<MouseMovedEventArguments> MouseMoved
        {
            add
            {
                if (_mouseMoved == null)
                    _input.MouseMoved += OnMouseMoved;
                _mouseMoved += value;
            }
            remove
            {
                _mouseMoved -= value;
                if (_mouseMoved == null)
                    _input.MouseMoved -= OnMouseMoved;
            }
        }

        private void OnMouseMoved(MouseMovedEventArgs args)
        {
            _mouseMoved?.Invoke(this, new MouseMovedEventArguments(args));
        }

        private EventHandler<MouseWheelEventArguments> _mouseWheel;

        public event EventHandler<MouseWheelEventArguments> MouseWheel
        {
            add
            {
                if (_mouseWheel == null)
                    _input.MouseWheel += OnMouseWheel;
                _mouseWheel += value;
            }
            remove
            {
                _mouseWheel -= value;
                if (_mouseWheel == null)
                    _input.MouseWheel -= OnMouseWheel;
            }
        }

        private void OnMouseWheel(MouseWheelEventArgs args)
        {
            _mouseWheel?.Invoke(this, new MouseWheelEventArguments(args));
        }

        public MouseMode MouseMode => _input.MouseMode;

        public bool MouseLocked => _input.MouseLocked;

        public bool MouseVisible => _input.MouseVisible;

        #endregion


        #region Text

        private EventHandler<TextInputEventArguments> _textInput;

        public event EventHandler<TextInputEventArguments> TextInput
        {
            add
            {
                if (_textInput == null)
                    _input.TextInput += OnTextInput;
                _textInput += value;
            }
            remove
            {
                _textInput -= value;
                if (_textInput == null)
                    _input.TextInput -= OnTextInput;
            }
        }

        private void OnTextInput(TextInputEventArgs args)
        {
            _textInput?.Invoke(this, new TextInputEventArguments(args));
        }

        #endregion

        #region Joystick

        private EventHandler<JoystickConnectedEventArguments> _joystickConnected;

        public event EventHandler<JoystickConnectedEventArguments> JoystickConnected
        {
            add
            {
                if (_joystickConnected == null)
                    _input.JoystickConnected += OnJoystickConnected;
                _joystickConnected += value;
            }
            remove
            {
                _joystickConnected -= value;
                if (_joystickConnected == null)
                    _input.JoystickConnected -= OnJoystickConnected;
            }
        }

        private void OnJoystickConnected(JoystickConnectedEventArgs args)
        {
            _joystickConnected?.Invoke(this, new JoystickConnectedEventArguments(args, _input));
        }

        private EventHandler<JoystickDisconnectedEventArguments> _joystickDisconnected;

        public event EventHandler<JoystickDisconnectedEventArguments> JoystickDisconnected
        {
            add
            {
                if (_joystickDisconnected == null)
                    _input.JoystickDisconnected += OnJoystickDisconnected;
                _joystickDisconnected += value;
            }
            remove
            {
                _joystickDisconnected -= value;
                if (_joystickDisconnected == null)
                    _input.JoystickDisconnected -= OnJoystickDisconnected;
            }
        }

        private void OnJoystickDisconnected(JoystickDisconnectedEventArgs args)
        {
            _joystickDisconnected?.Invoke(this, new JoystickDisconnectedEventArguments(args, _input));
        }

        private EventHandler<JoystickButtonDownEventArguments> _joystickButtonDown;

        public event EventHandler<JoystickButtonDownEventArguments> JoystickButtonDown
        {
            add
            {
                if (_joystickButtonDown == null)
                    _input.JoystickButtonDown += OnJoystickButtonDown;
                _joystickButtonDown += value;
            }
            remove
            {
                _joystickButtonDown -= value;
                if (_joystickButtonDown == null)
                    _input.JoystickButtonDown -= OnJoystickButtonDown;
            }
        }

        private void OnJoystickButtonDown(JoystickButtonDownEventArgs args)
        {
            _joystickButtonDown?.Invoke(this, new JoystickButtonDownEventArguments(args, _input));
        }

        private EventHandler<JoystickButtonUpEventArguments> _joystickButtonUp;

        public event EventHandler<JoystickButtonUpEventArguments> JoystickButtonUp
        {
            add
            {
                if (_joystickButtonUp == null)
                    _input.JoystickButtonUp += OnJoystickButtonUp;
                _joystickButtonUp += value;
            }
            remove
            {
                _joystickButtonUp -= value;
                if (_joystickButtonUp == null)
                    _input.JoystickButtonUp -= OnJoystickButtonUp;
            }
        }

        private void OnJoystickButtonUp(JoystickButtonUpEventArgs args)
        {
            _joystickButtonUp?.Invoke(this, new JoystickButtonUpEventArguments(args, _input));
        }

        private EventHandler<JoystickAxisMoveEventArguments> _joystickAxisMove;

        public event EventHandler<JoystickAxisMoveEventArguments> JoystickAxisMove
        {
            add
            {
                if (_joystickAxisMove == null)
                    _input.JoystickAxisMove += OnJoystickAxisMove;
                _joystickAxisMove += value;
            }
            remove
            {
                _joystickAxisMove -= value;
                if (_joystickAxisMove == null)
                    _input.JoystickAxisMove -= OnJoystickAxisMove;
            }
        }

        private void OnJoystickAxisMove(JoystickAxisMoveEventArgs args)
        {
            _joystickAxisMove?.Invoke(this, new JoystickAxisMoveEventArguments(args, _input));
        }

        private EventHandler<JoystickHatMoveEventArguments> _joystickHatMove;

        public event EventHandler<JoystickHatMoveEventArguments> JoystickHatMove
        {
            add
            {
                if (_joystickHatMove == null)
                    _input.JoystickHatMove += OnJoystickHatMove;
                _joystickHatMove += value;
            }
            remove
            {
                _joystickHatMove -= value;
                if (_joystickHatMove == null)
                    _input.JoystickHatMove -= OnJoystickHatMove;
            }
        }

        private void OnJoystickHatMove(JoystickHatMoveEventArgs args)
        {
            _joystickHatMove?.Invoke(this, new JoystickHatMoveEventArguments(args, _input));
        }

        #endregion

        #region Touch

        private EventHandler<TouchBeginEventArguments> _touchBegin;

        public event EventHandler<TouchBeginEventArguments> TouchBegin
        {
            add
            {
                if (_touchBegin == null)
                    _input.TouchBegin += OnTouchBegin;
                _touchBegin += value;
            }
            remove
            {
                _touchBegin -= value;
                if (_touchBegin == null)
                    _input.TouchBegin -= OnTouchBegin;
            }
        }

        private void OnTouchBegin(TouchBeginEventArgs args)
        {
            _touchBegin?.Invoke(this, new TouchBeginEventArguments(args));
        }

        private EventHandler<TouchEndEventArguments> _touchEnd;

        public event EventHandler<TouchEndEventArguments> TouchEnd
        {
            add
            {
                if (_touchEnd == null)
                    _input.TouchEnd += OnTouchEnd;
                _touchEnd += value;
            }
            remove
            {
                _touchEnd -= value;
                if (_touchEnd == null)
                    _input.TouchEnd -= OnTouchEnd;
            }
        }

        private void OnTouchEnd(TouchEndEventArgs args)
        {
            _touchEnd?.Invoke(this, new TouchEndEventArguments(args));
        }

        private EventHandler<TouchMoveEventArguments> _touchMove;

        public event EventHandler<TouchMoveEventArguments> TouchMove
        {
            add
            {
                if (_touchMove == null)
                    _input.TouchMove += OnTouchMove;
                _touchMove += value;
            }
            remove
            {
                _touchMove -= value;
                if (_touchMove == null)
                    _input.TouchMove -= OnTouchMove;
            }
        }

        private void OnTouchMove(TouchMoveEventArgs args)
        {
            _touchMove?.Invoke(this, new TouchMoveEventArguments(args));
        }

        #endregion

        #region Gesture

        private EventHandler<GestureRecordedEventArguments> _gestureRecorded;

        public event EventHandler<GestureRecordedEventArguments> GestureRecorded
        {
            add
            {
                if (_gestureRecorded == null)
                    _input.GestureRecorded += OnGestureRecorded;
                _gestureRecorded += value;
            }
            remove
            {
                _gestureRecorded -= value;
                if (_gestureRecorded == null)
                    _input.GestureRecorded -= OnGestureRecorded;
            }
        }

        private void OnGestureRecorded(GestureRecordedEventArgs args)
        {
            _gestureRecorded?.Invoke(this, new GestureRecordedEventArguments(args));
        }

        private EventHandler<GestureInputEventArguments> _gestureInput;

        public event EventHandler<GestureInputEventArguments> GestureInput
        {
            add
            {
                if (_gestureInput == null)
                    _input.GestureInput += OnGestureInput;
                _gestureInput += value;
            }
            remove
            {
                _gestureInput -= value;
                if (_gestureInput == null)
                    _input.GestureInput -= OnGestureInput;
            }
        }

        private void OnGestureInput(GestureInputEventArgs args)
        {
            _gestureInput?.Invoke(this, new GestureInputEventArguments(args));
        }

        private EventHandler<MultiGestureEventArguments> _multiGesture;

        public event EventHandler<MultiGestureEventArguments> MultiGesture
        {
            add
            {
                if (_multiGesture == null)
                    _input.MultiGesture += OnMultiGesture;
                _multiGesture += value;
            }
            remove
            {
                _multiGesture -= value;
                if (_multiGesture == null)
                    _input.MultiGesture -= OnMultiGesture;
            }
        }

        private void OnMultiGesture(MultiGestureEventArgs args)
        {
            _multiGesture?.Invoke(this, new MultiGestureEventArguments(args));
        }

        #endregion

        #region Drop Files

        private EventHandler<DropFileEventArguments> _dropFile;

        public event EventHandler<DropFileEventArguments> DropFile
        {
            add
            {
                if (_dropFile == null)
                    _input.DropFile += OnDropFile;
                _dropFile += value;
            }
            remove
            {
                _dropFile -= value;
                if (_dropFile == null)
                    _input.DropFile -= OnDropFile;
            }
        }

        private void OnDropFile(DropFileEventArgs args)
        {
            _dropFile?.Invoke(this, new DropFileEventArguments(args));
        }

        #endregion

        #region Misc

        private EventHandler<InputFocusEventArguments> _inputFocus;

        public event EventHandler<InputFocusEventArguments> InputFocus
        {
            add
            {
                if (_inputFocus == null)
                    _input.InputFocus += OnInputFocus;
                _inputFocus += value;
            }
            remove
            {
                _inputFocus -= value;
                if (_inputFocus == null)
                    _input.InputFocus -= OnInputFocus;
            }
        }

        private void OnInputFocus(InputFocusEventArgs args)
        {
            _inputFocus?.Invoke(this, new InputFocusEventArguments(args));
        }

        private EventHandler<ExitRequestedEventArguments> _exitRequested;

        public event EventHandler<ExitRequestedEventArguments> ExitRequested
        {
            add
            {
                if (_exitRequested == null)
                    _input.ExitRequested += OnExitRequested;
                _exitRequested += value;
            }
            remove
            {
                _exitRequested -= value;
                if (_exitRequested == null)
                    _input.ExitRequested -= OnExitRequested;
            }
        }

        private void OnExitRequested(ExitRequestedEventArgs args)
        {
            _exitRequested?.Invoke(this, new ExitRequestedEventArguments(args));
        }

        #endregion
    }
}