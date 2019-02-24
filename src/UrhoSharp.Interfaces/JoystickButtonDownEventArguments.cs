using Urho;

namespace UrhoSharp.Interfaces
{
    public class JoystickButtonDownEventArguments : JoystickButtonEventArguments
    {
        public JoystickButtonDownEventArguments(JoystickButtonDownEventArgs args, Input input) : base(args, input)
        {
        }
    }
}