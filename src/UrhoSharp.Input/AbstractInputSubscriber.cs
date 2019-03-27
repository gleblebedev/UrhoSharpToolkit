using UrhoSharp.Interfaces;

namespace UrhoSharp.Input
{
    public abstract class AbstractInputSubscriber : IInputSubscriber
    {
        public virtual void OnKeyCancel(object sender, KeyCancelEventArguments args)
        {
        }

        public virtual void OnKeyDown(object sender, KeyDownEventArguments args)
        {
        }

        public virtual void OnKeyUp(object sender, KeyUpEventArguments args)
        {
        }

        public virtual void OnMouseButtonCancel(object sender, MouseButtonCancelEventArguments args)
        {
        }

        public virtual void OnMouseButtonDown(object sender, MouseButtonDownEventArguments args)
        {
        }

        public virtual void OnMouseButtonUp(object sender, MouseButtonUpEventArguments args)
        {
        }

        public virtual void OnMouseMoved(object sender, MouseMovedEventArguments args)
        {
        }

        public virtual void OnMouseWheel(object sender, MouseWheelEventArguments args)
        {
        }

        public virtual void OnMouseVisibleChanged(object sender, MouseVisibleChangedEventArguments args)
        {
        }

        public virtual void OnMouseModeChanged(object sender, MouseModeChangedEventArguments args)
        {
        }

        public virtual void OnTextInput(object sender, TextInputEventArguments args)
        {
        }

        public virtual void OnJoystickConnected(object sender, JoystickConnectedEventArguments args)
        {
        }

        public virtual void OnJoystickDisconnected(object sender, JoystickDisconnectedEventArguments args)
        {
        }

        public virtual void OnJoystickButtonDown(object sender, JoystickButtonDownEventArguments args)
        {
        }

        public virtual void OnJoystickButtonUp(object sender, JoystickButtonUpEventArguments args)
        {
        }

        public virtual void OnJoystickButtonCancel(object sender, JoystickButtonCancelEventArguments args)
        {
        }

        public virtual void OnJoystickAxisMove(object sender, JoystickAxisMoveEventArguments args)
        {
        }

        public virtual void OnJoystickHatMove(object sender, JoystickHatMoveEventArguments args)
        {
        }

        public virtual void OnTouchBegin(object sender, TouchBeginEventArguments args)
        {
        }

        public virtual void OnTouchEnd(object sender, TouchEndEventArguments args)
        {
        }

        public virtual void OnTouchMove(object sender, TouchMoveEventArguments args)
        {
        }

        public virtual void OnTouchCancel(object sender, TouchCancelEventArguments args)
        {
        }

        public virtual void OnGestureRecorded(object sender, GestureRecordedEventArguments args)
        {
        }

        public virtual void OnGestureInput(object sender, GestureInputEventArguments args)
        {
        }

        public virtual void OnMultiGesture(object sender, MultiGestureEventArguments args)
        {
        }

        public virtual void OnDropFile(object sender, DropFileEventArguments args)
        {
        }

        public virtual void OnInputFocus(object sender, InputFocusEventArguments args)
        {
        }

        public virtual void OnExitRequested(object sender, ExitRequestedEventArguments args)
        {
        }

        public virtual void Update(float timeStep)
        {
        }
    }
}