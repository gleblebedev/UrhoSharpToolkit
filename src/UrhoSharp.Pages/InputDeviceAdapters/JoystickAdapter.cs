using System.Collections.Generic;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Pages.InputDeviceAdapters
{
    public class JoystickAdapter : AbstractInputDeviceAdapter
    {
        private readonly Dictionary<int, JoystickDeviceAdapter> _joysticks =
            new Dictionary<int, JoystickDeviceAdapter>();

        public JoystickAdapter(IInput input) : base(input)
        {
            Input.JoystickAxisMove += OnJoystickAxisMove;
            Input.JoystickButtonDown += OnJoystickButtonDown;
            Input.JoystickButtonUp += OnJoystickButtonUp;
            Input.JoystickConnected += OnJoystickConnected;
            Input.JoystickDisconnected += OnJoystickDisconnected;
            Input.JoystickHatMove += OnJoystickHatMove;
        }

        private void OnJoystickConnected(object sender, JoystickConnectedEventArguments args)
        {
            GetOrCreateDeviceAdapter(args);
        }

        private void OnJoystickDisconnected(object sender, JoystickDisconnectedEventArguments args)
        {
            Page?.OnJoystickDisconnected(sender, args);

            _joysticks.Remove(args.JoystickID);
        }

        public override void AssignPage(IScenePage page)
        {
            base.AssignPage(page);

            foreach (var joystickDeviceAdapter in _joysticks) joystickDeviceAdapter.Value.AssignPage(Page);
        }

        public override void ReleasePage(IScenePage page)
        {
            foreach (var joystickDeviceAdapter in _joysticks) joystickDeviceAdapter.Value.ReleasePage(Page);

            base.ReleasePage(page);
        }

        private JoystickDeviceAdapter GetOrCreateDeviceAdapter(JoystickEventArguments args)
        {
            JoystickDeviceAdapter state;
            if (!_joysticks.TryGetValue(args.JoystickID, out state))
            {
                state = new JoystickDeviceAdapter(args);
                if (Page != null)
                    state.AssignPage(Page);
                _joysticks.Add(args.JoystickID, state);

                Page?.OnJoystickConnected(this, new JoystickConnectedEventArguments(args));
            }

            return state;
        }

        private void OnJoystickButtonDown(object sender, JoystickButtonDownEventArguments args)
        {
            GetOrCreateDeviceAdapter(args).OnJoystickButtonDown(args);
        }

        private void OnJoystickButtonUp(object sender, JoystickButtonUpEventArguments args)
        {
            GetOrCreateDeviceAdapter(args).OnJoystickButtonUp(args);
        }

        private void OnJoystickAxisMove(object sender, JoystickAxisMoveEventArguments args)
        {
            if (Page == null)
                return;

            GetOrCreateDeviceAdapter(args).OnJoystickAxisMove(args);
        }

        private void OnJoystickHatMove(object sender, JoystickHatMoveEventArguments args)
        {
            if (Page == null)
                return;

            GetOrCreateDeviceAdapter(args).OnJoystickHatMove(args);
        }

        public override void Dispose()
        {
            Input.JoystickAxisMove -= OnJoystickAxisMove;
            Input.JoystickButtonDown -= OnJoystickButtonDown;
            Input.JoystickButtonUp -= OnJoystickButtonUp;
            Input.JoystickConnected -= OnJoystickConnected;
            Input.JoystickDisconnected -= OnJoystickDisconnected;
            Input.JoystickHatMove -= OnJoystickHatMove;
        }
    }
}