using Urho;

namespace UrhoSharp.Interfaces
{
    public class JoystickAxisMoveEventArguments : JoystickEventArguments
    {
        public JoystickAxisMoveEventArguments(JoystickAxisMoveEventArgs args) : base(args)
        {
            Axis = args.Button;
            Position = args.Position;
        }

        public int Axis { get; }
        public float Position { get; }
    }
}