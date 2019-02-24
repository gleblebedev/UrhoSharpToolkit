using Urho;

namespace UrhoSharp.Interfaces
{
    public class TouchMoveEventArguments : TouchEventArguments
    {
        public TouchMoveEventArguments(TouchMoveEventArgs args) : base(args)
        {
            DX = args.DX;
            DY = args.DY;
            Pressure = args.Pressure;
        }

        public int DX { get; }
        public int DY { get; }
        public float Pressure { get; }
    }
}