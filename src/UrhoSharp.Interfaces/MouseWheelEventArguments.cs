using Urho;

namespace UrhoSharp.Interfaces
{
    public class MouseWheelEventArguments : MouseEventArguments
    {
        public MouseWheelEventArguments(MouseWheelEventArgs args) : base(args)
        {
            Wheel = args.Wheel;
        }

        public int Wheel { get; }
    }
}