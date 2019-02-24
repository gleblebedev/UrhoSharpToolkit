using Urho;

namespace UrhoSharp.Interfaces
{
    public class JoystickButtonEventArguments : JoystickEventArguments
    {
        public JoystickButtonEventArguments(JoystickButtonDownEventArgs args) : base(args)
        {
            Button = args.Button;
        }

        public JoystickButtonEventArguments(JoystickButtonUpEventArgs args) : base(args)
        {
            Button = args.Button;
        }

        public int Button { get; }
    }
}