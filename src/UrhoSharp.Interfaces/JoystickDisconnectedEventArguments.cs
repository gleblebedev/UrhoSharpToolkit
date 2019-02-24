using Urho;

namespace UrhoSharp.Interfaces
{
    public class JoystickDisconnectedEventArguments : JoystickEventArguments
    {
        public JoystickDisconnectedEventArguments(JoystickDisconnectedEventArgs args, Input input) : base(args, input)
        {
        }
    }
}