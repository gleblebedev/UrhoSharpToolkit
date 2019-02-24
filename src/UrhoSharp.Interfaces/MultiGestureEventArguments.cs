using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class MultiGestureEventArguments : EventArgs
    {
        public MultiGestureEventArguments(MultiGestureEventArgs args)
        {
            CenterX = args.CenterX;
            CenterY = args.CenterY;
            NumFingers = args.NumFingers;
            DTheta = args.DTheta;
            DDist = args.DDist;
        }

        public int CenterX { get; }
        public int CenterY { get; }
        public int NumFingers { get; }
        public float DTheta { get; }
        public float DDist { get; }
    }
}