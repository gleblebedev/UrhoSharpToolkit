using UrhoSharp.Interfaces;

namespace UrhoSharp.HierarchicalNavigation
{
    public interface IInputSubscriber
    {
        void OnKeyCancel(object sender, KeyCancelEventArguments args);
        void OnKeyDown(object sender, KeyDownEventArguments args);
        void OnKeyUp(object sender, KeyUpEventArguments args);

        void OnMouseButtonCancel(object sender, MouseButtonCancelEventArguments args);
        void OnMouseButtonDown(object sender, MouseButtonDownEventArguments args);
        void OnMouseButtonUp(object sender, MouseButtonUpEventArguments args);
        void OnMouseMoved(object sender, MouseMovedEventArguments args);
        void OnMouseWheel(object sender, MouseWheelEventArguments args);
        void OnMouseVisibleChanged(object sender, MouseVisibleChangedEventArguments args);
        void OnMouseModeChanged(object sender, MouseModeChangedEventArguments args);

        void OnTextInput(object sender, TextInputEventArguments args);
        void OnJoystickConnected(object sender, JoystickConnectedEventArguments args);
        void OnJoystickDisconnected(object sender, JoystickDisconnectedEventArguments args);
        void OnJoystickButtonDown(object sender, JoystickButtonDownEventArguments args);
        void OnJoystickButtonUp(object sender, JoystickButtonUpEventArguments args);
        void OnJoystickAxisMove(object sender, JoystickAxisMoveEventArguments args);
        void OnJoystickHatMove(object sender, JoystickHatMoveEventArguments args);
        void OnTouchBegin(object sender, TouchBeginEventArguments args);
        void OnTouchEnd(object sender, TouchEndEventArguments args);
        void OnTouchMove(object sender, TouchMoveEventArguments args);
        void OnGestureRecorded(object sender, GestureRecordedEventArguments args);
        void OnGestureInput(object sender, GestureInputEventArguments args);
        void OnMultiGesture(object sender, MultiGestureEventArguments args);
        void OnDropFile(object sender, DropFileEventArguments args);
        void OnInputFocus(object sender, InputFocusEventArguments args);
        void OnExitRequested(object sender, ExitRequestedEventArguments args);
    }
}