using UrhoSharp.Interfaces;

namespace UrhoSharp.Pages.InputDeviceAdapters
{
    public class JoystickAdapter : AbstractInputDeviceAdapter
    {
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
            if (Page == null)
                return;

            Page.OnJoystickConnected(sender, args);
        }

        private void OnJoystickDisconnected(object sender, JoystickDisconnectedEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnJoystickDisconnected(sender, args);
        }

        private void OnJoystickButtonDown(object sender, JoystickButtonDownEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnJoystickButtonDown(sender, args);
        }

        private void OnJoystickButtonUp(object sender, JoystickButtonUpEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnJoystickButtonUp(sender, args);
        }

        private void OnJoystickAxisMove(object sender, JoystickAxisMoveEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnJoystickAxisMove(sender, args);
        }

        private void OnJoystickHatMove(object sender, JoystickHatMoveEventArguments args)
        {
            if (Page == null)
                return;

            Page.OnJoystickHatMove(sender, args);
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