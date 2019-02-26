using System;
using System.Collections.Generic;
using UrhoSharp.Input;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Input.InputDeviceAdapters
{
    public class JoystickDeviceAdapter
    {
        private readonly Dictionary<int, float> _activeAxis = new Dictionary<int, float>();

        private readonly HashSet<int> _activeButtons = new HashSet<int>();

        public JoystickDeviceAdapter(JoystickEventArguments args)
        {
            JoystickID = args.JoystickID;
            IsController = args.IsController;
            NumAxis = args.NumAxes;
            NumButtons = args.NumButtons;
            NumHats = args.NumHats;
        }

        public int NumButtons { get; }

        public int NumAxis { get; }
        public int NumHats { get; }

        public bool IsController { get; }

        public int JoystickID { get; }

        public float DeadZone { get; set; } = 0.1f;

        public IInputSubscriber Page { get; private set; }

        public void OnJoystickButtonDown(JoystickButtonDownEventArguments args)
        {
            _activeButtons.Add(args.Button);
            Page?.OnJoystickButtonDown(this, args);
        }

        public void AssignPage(IInputSubscriber page)
        {
            Page = page;
        }

        public void ReleasePage(IInputSubscriber page)
        {
            OnFocusLost();
            Page = null;
        }

        public void OnJoystickButtonUp(JoystickButtonUpEventArguments args)
        {
            if (_activeButtons.Remove(args.Button)) Page?.OnJoystickButtonUp(this, args);
        }

        public void OnJoystickButtonCancel(JoystickButtonCancelEventArguments args)
        {
            if (_activeButtons.Remove(args.Button)) Page?.OnJoystickButtonCancel(this, args);
        }

        public void OnJoystickAxisMove(JoystickAxisMoveEventArguments args)
        {
            var axis = args.Axis;
            var value = ApplyDeadZone(args.Position);

            float prevValue;
            if (_activeAxis.TryGetValue(axis, out prevValue))
                if (Math.Abs(prevValue - value) < 1e-2f)
                    return;

            _activeAxis[axis] = value;

            Page?.OnJoystickAxisMove(this, new JoystickAxisMoveEventArguments(args, axis, value));
        }

        private float ApplyDeadZone(float position)
        {
            if (position <= DeadZone && position >= -DeadZone)
                return 0.0f;
            return position;
        }

        public void OnJoystickHatMove(JoystickHatMoveEventArguments args)
        {
            Page?.OnJoystickHatMove(this, args);
        }

        public void OnFocusLost()
        {
            if (Page == null)
                return;
            foreach (var activeButton in _activeButtons)
                Page?.OnJoystickButtonCancel(this,
                    new JoystickButtonCancelEventArguments(JoystickID, IsController, NumAxis, NumButtons, NumHats,
                        activeButton));
            _activeButtons.Clear();
        }
    }
}