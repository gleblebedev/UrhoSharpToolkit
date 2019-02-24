using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class KeyEventArguments : EventArgs
    {
        protected KeyEventArguments(KeyDownEventArgs args)
        {
            Key = args.Key;
            Buttons = args.Buttons;
            Qualifiers = args.Qualifiers;
            Repeat = args.Repeat;
            Scancode = args.Scancode;
        }

        protected KeyEventArguments(KeyUpEventArgs args)
        {
            Key = args.Key;
            Buttons = args.Buttons;
            Qualifiers = args.Qualifiers;
            Repeat = false;
            Scancode = args.Scancode;
        }

        protected KeyEventArguments(KeyEventArguments args)
        {
            Key = args.Key;
            Buttons = args.Buttons;
            Qualifiers = args.Qualifiers;
            Repeat = args.Repeat;
            Scancode = args.Scancode;
        }

        protected KeyEventArguments(Key key, int scancode, bool repeat, int buttons, int qualifiers)
        {
            Key = key;
            Buttons = buttons;
            Qualifiers = qualifiers;
            Repeat = repeat;
            Scancode = scancode;
        }

        public int Scancode { get; }

        public int Qualifiers { get; }

        public int Buttons { get; }

        public Key Key { get; }
        public bool Repeat { get; }
    }
}