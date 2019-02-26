using Urho;

namespace UrhoSharp.Interfaces
{
    public class JoystickButtonEventArguments : JoystickEventArguments
    {
        public JoystickButtonEventArguments(JoystickButtonDownEventArgs args, Input input) : base(args, input)
        {
            Button = args.Button;
        }

        public JoystickButtonEventArguments(JoystickButtonEventArguments args) : base(args)
        {
            Button = args.Button;
        }

        public JoystickButtonEventArguments(int joystickID, bool isController, int numAxes, int numButtons, int numHats,
            int button) : base(joystickID, isController, numAxes, numButtons, numHats)
        {
            Button = button;
        }

        public JoystickButtonEventArguments(JoystickButtonUpEventArgs args, Input input) : base(args, input)
        {
            Button = args.Button;
        }

        public int Button { get; }
    }
}