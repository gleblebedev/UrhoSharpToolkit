using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class InputFocusEventArguments : EventArgs
    {
        public InputFocusEventArguments(InputFocusEventArgs args)
        {
            Focus = args.Focus;
            Minimized = args.Minimized;
        }

        public bool Focus { get; }
        public bool Minimized { get; }
    }
}