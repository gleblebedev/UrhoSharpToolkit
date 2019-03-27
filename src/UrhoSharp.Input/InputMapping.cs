using System.Collections.Generic;
using Urho;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Input
{
    public class InputMapping : IInputSubscriber
    {
        private readonly List<int> _activeTouches = new List<int>(4);
        private readonly Dictionary<int, ITriggerAction> _axisMapping = new Dictionary<int, ITriggerAction>();
        private readonly Dictionary<Key, ITriggerAction> _keyboardMapping = new Dictionary<Key, ITriggerAction>();

        private readonly Dictionary<MouseButton, ITriggerAction> _mouseButtonMapping =
            new Dictionary<MouseButton, ITriggerAction>();

        private readonly List<PointerArgs> _touchArgs = new List<PointerArgs>(4);
        private readonly InputDispatcher _unhandledInput = new InputDispatcher();

        private IPointerAction _pointerAction;
        private ITouchAction _touchAction;
        private bool _touchAdded;

        public IInputSubscriber NextInputSubscriber
        {
            get => _unhandledInput.Subscriber;
            set => _unhandledInput.Subscriber = value;
        }

        public virtual void OnKeyCancel(object sender, KeyCancelEventArguments args)
        {
            ITriggerAction action;
            if (_keyboardMapping.TryGetValue(args.Key, out action))
            {
                action.Cancel();
                return;
            }

            _unhandledInput.OnKeyCancel(sender, args);
        }

        public virtual void OnKeyDown(object sender, KeyDownEventArguments args)
        {
            ITriggerAction action;
            if (_keyboardMapping.TryGetValue(args.Key, out action))
            {
                action.StartOrUpdate(1.0f);
                return;
            }

            _unhandledInput.OnKeyDown(sender, args);
        }

        public virtual void OnKeyUp(object sender, KeyUpEventArguments args)
        {
            ITriggerAction action;
            if (_keyboardMapping.TryGetValue(args.Key, out action))
            {
                action.Stop();
                return;
            }

            _unhandledInput.OnKeyUp(sender, args);
        }

        public virtual void OnMouseButtonCancel(object sender, MouseButtonCancelEventArguments args)
        {
            ITriggerAction action;
            if (_mouseButtonMapping.TryGetValue((MouseButton) args.Button, out action))
            {
                action.Cancel();
                return;
            }

            _unhandledInput.OnMouseButtonCancel(sender, args);
        }

        public virtual void OnMouseButtonDown(object sender, MouseButtonDownEventArguments args)
        {
            ITriggerAction action;
            if (_mouseButtonMapping.TryGetValue((MouseButton) args.Button, out action))
            {
                action.StartOrUpdate(1.0f);
                return;
            }

            _unhandledInput.OnMouseButtonDown(sender, args);
        }

        public virtual void OnMouseButtonUp(object sender, MouseButtonUpEventArguments args)
        {
            ITriggerAction action;
            if (_mouseButtonMapping.TryGetValue((MouseButton) args.Button, out action))
            {
                action.Stop();
                return;
            }

            _unhandledInput.OnMouseButtonUp(sender, args);
        }

        public virtual void OnMouseMoved(object sender, MouseMovedEventArguments args)
        {
            if (_pointerAction != null)
            {
                _pointerAction.StartOrUpdate(
                    new PointerArgs(new Vector2(args.DX, args.DY), new Vector2(args.X, args.Y)));
                return;
            }

            _unhandledInput.OnMouseMoved(sender, args);
        }

        public virtual void OnMouseWheel(object sender, MouseWheelEventArguments args)
        {
            _unhandledInput.OnMouseWheel(sender, args);
        }

        public virtual void OnMouseVisibleChanged(object sender, MouseVisibleChangedEventArguments args)
        {
            _unhandledInput.OnMouseVisibleChanged(sender, args);
        }

        public virtual void OnMouseModeChanged(object sender, MouseModeChangedEventArguments args)
        {
            _unhandledInput.OnMouseModeChanged(sender, args);
        }

        public virtual void OnTextInput(object sender, TextInputEventArguments args)
        {
            _unhandledInput.OnTextInput(sender, args);
        }

        public virtual void OnJoystickConnected(object sender, JoystickConnectedEventArguments args)
        {
            _unhandledInput.OnJoystickConnected(sender, args);
        }

        public virtual void OnJoystickDisconnected(object sender, JoystickDisconnectedEventArguments args)
        {
            _unhandledInput.OnJoystickDisconnected(sender, args);
        }

        public virtual void OnJoystickButtonDown(object sender, JoystickButtonDownEventArguments args)
        {
            _unhandledInput.OnJoystickButtonDown(sender, args);
        }

        public virtual void OnJoystickButtonUp(object sender, JoystickButtonUpEventArguments args)
        {
            _unhandledInput.OnJoystickButtonUp(sender, args);
        }

        public virtual void OnJoystickButtonCancel(object sender, JoystickButtonCancelEventArguments args)
        {
            _unhandledInput.OnJoystickButtonCancel(sender, args);
        }

        public virtual void OnJoystickAxisMove(object sender, JoystickAxisMoveEventArguments args)
        {
            ITriggerAction action;
            if (_axisMapping.TryGetValue(args.Axis, out action))
            {
                action.StartOrUpdate(args.Position);
                return;
            }

            _unhandledInput.OnJoystickAxisMove(sender, args);
        }

        public virtual void OnJoystickHatMove(object sender, JoystickHatMoveEventArguments args)
        {
            _unhandledInput.OnJoystickHatMove(sender, args);
        }

        public virtual void OnTouchBegin(object sender, TouchBeginEventArguments args)
        {
            if (_touchAction != null)
            {
                var index = _activeTouches.IndexOf(args.TouchID);
                if (index < 0)
                {
                    if (_activeTouches.Count > 0)
                        _touchAction.Cancel();
                    _activeTouches.Add(args.TouchID);
                    _touchArgs.Add(new PointerArgs(new Vector2(0, 0), new Vector2(args.X, args.Y)));
                    _touchAdded = true;
                    _touchAction.Start(new TouchArgs(_touchArgs, _touchAdded));
                    return;
                }

                var newPos = new Vector2(args.X, args.Y);
                _touchArgs[index] = new PointerArgs(new Vector2(0, 0), newPos);
                _touchAction.Update(new TouchArgs(_touchArgs, _touchAdded));
                return;
            }

            _unhandledInput.OnTouchBegin(sender, args);
        }

        public virtual void OnTouchEnd(object sender, TouchEndEventArguments args)
        {
            if (_touchAction != null)
            {
                var index = _activeTouches.IndexOf(args.TouchID);
                if (index >= 0)
                {
                    _touchAction.Complete(new TouchArgs(_touchArgs, _touchAdded));
                    _touchAdded = false;
                    _touchArgs.RemoveAt(index);
                    _activeTouches.RemoveAt(index);
                    if (_activeTouches.Count > 0)
                        _touchAction.Start(new TouchArgs(_touchArgs, _touchAdded));
                    return;
                }
            }

            _unhandledInput.OnTouchEnd(sender, args);
        }

        public virtual void OnTouchMove(object sender, TouchMoveEventArguments args)
        {
            if (_touchAction != null)
            {
                var index = _activeTouches.IndexOf(args.TouchID);
                if (index >= 0)
                {
                    _touchArgs[index] = new PointerArgs(new Vector2(args.DX, args.DY), new Vector2(args.X, args.Y));
                    _touchAction.Update(new TouchArgs(_touchArgs, _touchAdded));
                    return;
                }
            }

            _unhandledInput.OnTouchMove(sender, args);
        }

        public virtual void OnTouchCancel(object sender, TouchCancelEventArguments args)
        {
            if (_touchAction != null)
            {
                var index = _activeTouches.IndexOf(args.TouchID);
                if (index >= 0)
                {
                    _touchAction.Cancel();
                    _touchArgs.RemoveAt(index);
                    _activeTouches.RemoveAt(index);
                    return;
                }
            }

            _unhandledInput.OnTouchCancel(sender, args);
        }

        public virtual void OnGestureRecorded(object sender, GestureRecordedEventArguments args)
        {
            _unhandledInput.OnGestureRecorded(sender, args);
        }

        public virtual void OnGestureInput(object sender, GestureInputEventArguments args)
        {
            _unhandledInput.OnGestureInput(sender, args);
        }

        public virtual void OnMultiGesture(object sender, MultiGestureEventArguments args)
        {
            _unhandledInput.OnMultiGesture(sender, args);
        }

        public virtual void OnDropFile(object sender, DropFileEventArguments args)
        {
            _unhandledInput.OnDropFile(sender, args);
        }

        public virtual void OnInputFocus(object sender, InputFocusEventArguments args)
        {
            if (!args.Focus)
                if (_pointerAction != null)
                    _pointerAction.Cancel();

            _unhandledInput.OnInputFocus(sender, args);
        }

        public virtual void OnExitRequested(object sender, ExitRequestedEventArguments args)
        {
            _unhandledInput.OnExitRequested(sender, args);
        }

        public virtual void Update(float timeStep)
        {
            NextInputSubscriber?.Update(timeStep);
        }

        public void MapKey(Key key, ITriggerAction action)
        {
            if (action == null)
                _keyboardMapping.Remove(key);
            else
                _keyboardMapping[key] = action;
        }

        public void MapJoystickAxis(int axis, ITriggerAction action)
        {
            if (action == null)
                _axisMapping.Remove(axis);
            else
                _axisMapping[axis] = action;
        }

        public void MapMouseButton(MouseButton button, ITriggerAction action)
        {
            if (action == null)
                _mouseButtonMapping.Remove(button);
            else
                _mouseButtonMapping[button] = action;
        }

        public void MapPointer(IPointerAction action)
        {
            _pointerAction = action;
        }

        public void MapTouch(ITouchAction action)
        {
            _touchAction = action;
        }
    }
}