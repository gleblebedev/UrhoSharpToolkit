using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class MouseModeChangedEventArguments : EventArgs
    {
        public MouseModeChangedEventArguments(MouseModeChangedEventArgs args)
        {
            Mode = args.Mode;
            MouseLocked = args.MouseLocked;
        }

        public MouseMode Mode { get; }
        public bool MouseLocked { get; }
    }
}