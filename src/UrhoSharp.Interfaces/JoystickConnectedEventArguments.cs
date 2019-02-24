using Urho;

namespace UrhoSharp.Interfaces
{
    public class JoystickConnectedEventArguments : JoystickEventArguments
    {
        public JoystickConnectedEventArguments(JoystickConnectedEventArgs args, Input input) : base(args, input)
        {
        }

        public JoystickConnectedEventArguments(JoystickEventArguments args) : base(args)
        {
        }
    }
}