using System;

namespace UrhoSharp.Interfaces
{
    public interface IInput
    {
        event EventHandler<MouseButtonDownEventArguments> MouseButtonDown;
        event EventHandler<MouseButtonUpEventArguments> MouseButtonUp;
        event EventHandler<MouseMovedEventArguments> MouseMoved;
        event EventHandler<MouseWheelEventArguments> MouseWheel;
        event EventHandler<KeyDownEventArguments> KeyDown;
        event EventHandler<KeyUpEventArguments> KeyUp;
        event EventHandler<TextInputEventArguments> TextInput;
        event EventHandler<JoystickConnectedEventArguments> JoystickConnected;
        event EventHandler<JoystickDisconnectedEventArguments> JoystickDisconnected;
        event EventHandler<JoystickButtonDownEventArguments> JoystickButtonDown;
        event EventHandler<JoystickButtonUpEventArguments> JoystickButtonUp;
        event EventHandler<JoystickAxisMoveEventArguments> JoystickAxisMove;
        event EventHandler<JoystickHatMoveEventArguments> JoystickHatMove;
        event EventHandler<TouchBeginEventArguments> TouchBegin;
        event EventHandler<TouchEndEventArguments> TouchEnd;
        event EventHandler<TouchMoveEventArguments> TouchMove;
        event EventHandler<GestureRecordedEventArguments> GestureRecorded;
        event EventHandler<GestureInputEventArguments> GestureInput;
        event EventHandler<MultiGestureEventArguments> MultiGesture;
        event EventHandler<DropFileEventArguments> DropFile;
        event EventHandler<InputFocusEventArguments> InputFocus;
        event EventHandler<MouseVisibleChangedEventArguments> MouseVisibleChanged;
        event EventHandler<MouseModeChangedEventArguments> MouseModeChanged;
        event EventHandler<ExitRequestedEventArguments> ExitRequested;
    }
}