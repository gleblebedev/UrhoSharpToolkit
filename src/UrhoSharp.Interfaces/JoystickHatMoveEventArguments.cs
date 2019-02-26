using Urho;

namespace UrhoSharp.Interfaces
{
    public class JoystickHatMoveEventArguments : JoystickEventArguments
    {
        public JoystickHatMoveEventArguments(JoystickHatMoveEventArgs args, Input input) : base(args, input)
        {
            Hat = args.Button;
            Position = (HatPosition) args.Position;
        }

        public int Hat { get; }
        public HatPosition Position { get; }
    }
}