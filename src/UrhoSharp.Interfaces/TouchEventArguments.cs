using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class TouchEventArguments : EventArgs
    {
        public TouchEventArguments(TouchBeginEventArgs args)
        {
            TouchID = args.TouchID;
            X = args.X;
            Y = args.Y;
        }

        protected TouchEventArguments(TouchEndEventArgs args)
        {
            TouchID = args.TouchID;
            X = args.X;
            Y = args.Y;
        }

        protected TouchEventArguments(TouchMoveEventArgs args)
        {
            TouchID = args.TouchID;
            X = args.X;
            Y = args.Y;
        }

        public int TouchID { get; }
        public int X { get; }
        public int Y { get; }
    }
}