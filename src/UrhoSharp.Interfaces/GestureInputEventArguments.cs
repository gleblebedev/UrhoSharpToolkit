using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class GestureInputEventArguments : EventArgs
    {
        public GestureInputEventArguments(GestureInputEventArgs args)
        {
            GestureID = args.GestureID;
            CenterX = args.CenterX;
            CenterY = args.CenterY;
            NumFingers = args.NumFingers;
            Error = args.Error;
        }

        public uint GestureID { get; }
        public int CenterX { get; }
        public int CenterY { get; }
        public int NumFingers { get; }
        public float Error { get; }
    }
}