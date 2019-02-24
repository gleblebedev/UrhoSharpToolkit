using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class MouseVisibleChangedEventArguments : EventArgs
    {
        public MouseVisibleChangedEventArguments(MouseVisibleChangedEventArgs args)
        {
            Visible = args.Visible;
        }

        public bool Visible { get; }
    }
}