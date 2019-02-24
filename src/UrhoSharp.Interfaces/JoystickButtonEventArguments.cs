using Urho;

namespace UrhoSharp.Interfaces
{
    public class JoystickButtonEventArguments : JoystickEventArguments
    {
        public JoystickButtonEventArguments(JoystickButtonDownEventArgs args, Input input) : base(args, input)
        {
            Button = args.Button;
        }

        public JoystickButtonEventArguments(JoystickButtonUpEventArgs args, Input input) : base(args, input)
        {
            Button = args.Button;
        }

        public int Button { get; }
    }
}