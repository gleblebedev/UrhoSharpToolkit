using Urho;

namespace UrhoSharp.Interfaces
{
    public class JoystickButtonUpEventArguments : JoystickButtonEventArguments
    {
        public JoystickButtonUpEventArguments(JoystickButtonUpEventArgs args, Input input) : base(args, input)
        {
        }
    }
}