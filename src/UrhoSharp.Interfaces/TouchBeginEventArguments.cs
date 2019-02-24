using Urho;

namespace UrhoSharp.Interfaces
{
    public class TouchBeginEventArguments : TouchEventArguments
    {
        public TouchBeginEventArguments(TouchBeginEventArgs args) : base(args)
        {
            Pressure = args.Pressure;
        }

        public float Pressure { get; }
    }
}