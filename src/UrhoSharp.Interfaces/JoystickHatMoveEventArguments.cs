using Urho;

namespace UrhoSharp.Interfaces
{
    public class JoystickHatMoveEventArguments : JoystickEventArguments
    {
        public JoystickHatMoveEventArguments(JoystickHatMoveEventArgs args) : base(args)
        {
            Button = args.Button;
            Position = args.Position;
        }

        public int Button { get; }
        public int Position { get; }
    }
}