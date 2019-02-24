using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class JoystickEventArguments : EventArgs
    {
        public JoystickEventArguments(JoystickConnectedEventArgs args)
        {
            JoystickID = args.JoystickID;
        }

        public JoystickEventArguments(JoystickDisconnectedEventArgs args)
        {
            JoystickID = args.JoystickID;
        }

        protected JoystickEventArguments(JoystickHatMoveEventArgs args)
        {
            JoystickID = args.JoystickID;
        }

        protected JoystickEventArguments(JoystickButtonDownEventArgs args)
        {
            JoystickID = args.JoystickID;
        }

        protected JoystickEventArguments(JoystickButtonUpEventArgs args)
        {
            JoystickID = args.JoystickID;
        }

        protected JoystickEventArguments(JoystickAxisMoveEventArgs args)
        {
            JoystickID = args.JoystickID;
        }

        public int JoystickID { get; }
    }
}