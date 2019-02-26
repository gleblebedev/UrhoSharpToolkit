namespace UrhoSharp.Interfaces
{
    public class JoystickButtonCancelEventArguments : JoystickButtonEventArguments
    {
        public JoystickButtonCancelEventArguments(JoystickButtonEventArguments args) : base(args)
        {
        }

        public JoystickButtonCancelEventArguments(int joystickID, bool isController, int numAxes, int numButtons,
            int numHats, int button) : base(joystickID, isController, numAxes, numButtons, numHats, button)
        {
        }
    }
}