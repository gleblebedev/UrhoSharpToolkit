using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class TextInputEventArguments : EventArgs
    {
        public TextInputEventArguments(TextInputEventArgs args)
        {
            Text = args.Text;
        }

        public string Text { get; }
    }
}