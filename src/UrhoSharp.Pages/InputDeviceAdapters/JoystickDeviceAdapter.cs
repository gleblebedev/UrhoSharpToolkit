using System;
using System.Collections.Generic;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Pages.InputDeviceAdapters
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
        }

        public int NumButtons { get; }

        public int NumAxis { get; }

        public bool IsController { get; }

        public int JoystickID { get; }

        public float DeadZone { get; set; } = 0.1f;

        public IScenePage Page { get; private set; }

        public void OnJoystickButtonDown(JoystickButtonDownEventArguments args)
        {
            _activeButtons.Add(args.Button);
            Page?.OnJoystickButtonDown(this, args);
        }

        public void AssignPage(IScenePage page)
        {
            Page = page;
        }

        public void ReleasePage(IScenePage page)
        {
            Page = null;
        }

        public void OnJoystickButtonUp(JoystickButtonUpEventArguments args)
        {
            if (_activeButtons.Remove(args.Button)) Page?.OnJoystickButtonUp(this, args);
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
    }
}