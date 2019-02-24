using Urho;

namespace UrhoSharp.Interfaces
{
    public class JoystickAxisMoveEventArguments : JoystickEventArguments
    {
        public JoystickAxisMoveEventArguments(JoystickAxisMoveEventArgs args, Input input) : base(args, input)
        {
            Axis = args.Button;
            Position = args.Position;
        }

        public JoystickAxisMoveEventArguments(JoystickEventArguments args, int axis, float position) : base(args)
        {
            Axis = axis;
            Position = position;
        }

        public int Axis { get; }
        public float Position { get; }
    }
}