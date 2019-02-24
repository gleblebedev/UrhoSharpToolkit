using Urho;

namespace UrhoSharp.Interfaces
{
    public class MouseButtonEventArguments : MouseEventArguments
    {
        public MouseButtonEventArguments(MouseButtonUpEventArgs args) : base(args)
        {
            Button = args.Button;
        }

        public MouseButtonEventArguments(MouseButtonDownEventArgs args) : base(args)
        {
            Button = args.Button;
        }

        public MouseButtonEventArguments(MouseButtonEventArguments args) : base(args)
        {
            Button = args.Button;
        }

        public int Button { get; }
    }
}