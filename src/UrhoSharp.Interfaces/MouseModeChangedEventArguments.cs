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

        public MouseModeChangedEventArguments(MouseMode mode, bool locked)
        {
            Mode = mode;
            MouseLocked = locked;
        }

        public MouseMode Mode { get; }
        public bool MouseLocked { get; }
    }
}