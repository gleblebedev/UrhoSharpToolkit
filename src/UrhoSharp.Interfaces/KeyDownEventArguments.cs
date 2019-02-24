using Urho;

namespace UrhoSharp.Interfaces
{
    public class KeyDownEventArguments : KeyEventArguments
    {
        public KeyDownEventArguments(KeyDownEventArgs args) : base(args)
        {
        }

        public KeyDownEventArguments(Key key, int scancode, bool repeat, int buttons, int qualifiers) : base(key,
            scancode, repeat, buttons, qualifiers)
        {
        }
    }
}