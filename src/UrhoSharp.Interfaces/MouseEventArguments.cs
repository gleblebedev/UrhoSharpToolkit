using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class MouseEventArguments : EventArgs
    {
        public MouseEventArguments(MouseButtonUpEventArgs args)
        {
            Qualifiers = args.Qualifiers;
            Buttons = (MouseButton) args.Buttons;
        }

        public MouseEventArguments(MouseButtonDownEventArgs args)
        {
            Qualifiers = args.Qualifiers;
            Buttons = (MouseButton) args.Buttons;
        }

        public MouseEventArguments(MouseButtonEventArguments args)
        {
            Qualifiers = args.Qualifiers;
            Buttons = args.Buttons;
        }

        public MouseEventArguments(MouseMovedEventArgs args)
        {
            Qualifiers = args.Qualifiers;
            Buttons = (MouseButton) args.Buttons;
        }

        public MouseEventArguments(MouseWheelEventArgs args)
        {
            Qualifiers = args.Qualifiers;
            Buttons = (MouseButton) args.Buttons;
        }

        public int Qualifiers { get; }

        public MouseButton Buttons { get; }
    }
}