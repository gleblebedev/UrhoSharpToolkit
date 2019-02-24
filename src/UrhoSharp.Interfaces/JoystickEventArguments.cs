using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class JoystickEventArguments : EventArgs
    {
        public JoystickEventArguments(JoystickEventArguments args)
        {
            JoystickID = args.JoystickID;
            IsController = args.IsController;
            NumAxes = args.NumAxes;
            NumButtons = args.NumButtons;
        }

        public JoystickEventArguments(JoystickConnectedEventArgs args, Input input)
        {
            JoystickID = args.JoystickID;
            GetExtraInfo(input);
        }

        public JoystickEventArguments(JoystickDisconnectedEventArgs args, Input input)
        {
            JoystickID = args.JoystickID;
            GetExtraInfo(input);
        }

        protected JoystickEventArguments(JoystickHatMoveEventArgs args, Input input)
        {
            JoystickID = args.JoystickID;
            GetExtraInfo(input);
        }

        protected JoystickEventArguments(JoystickButtonDownEventArgs args, Input input)
        {
            JoystickID = args.JoystickID;
            GetExtraInfo(input);
        }

        protected JoystickEventArguments(JoystickButtonUpEventArgs args, Input input)
        {
            JoystickID = args.JoystickID;
            GetExtraInfo(input);
        }

        protected JoystickEventArguments(JoystickAxisMoveEventArgs args, Input input)
        {
            JoystickID = args.JoystickID;
            GetExtraInfo(input);
        }

        public int NumHats { get; private set; }

        public int NumButtons { get; private set; }

        public int NumAxes { get; private set; }

        public bool IsController { get; private set; }

        public int JoystickID { get; }

        private void GetExtraInfo(Input input)
        {
            unsafe
            {
                var info = input.GetJoystick(JoystickID);
                if (info != null)
                {
                    IsController = info->ControllerPtr != IntPtr.Zero;
                    NumAxes = (int) info->Axes.Size;
                    NumButtons = (int) info->Buttons.Size;
                    NumHats = (int) info->Hats.Size;
                }
            }
        }
    }
}