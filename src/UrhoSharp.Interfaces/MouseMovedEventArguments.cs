using Urho;

namespace UrhoSharp.Interfaces
{
    public class MouseMovedEventArguments : MouseEventArguments
    {
        public MouseMovedEventArguments(MouseMovedEventArgs args) : base(args)
        {
            X = args.X;
            Y = args.Y;
            DX = args.DX;
            DY = args.DY;
        }

        public int X { get; }
        public int Y { get; }
        public int DX { get; }
        public int DY { get; }
    }
}