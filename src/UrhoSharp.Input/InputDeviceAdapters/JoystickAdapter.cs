using System.Collections.Generic;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Input.InputDeviceAdapters
{
    public class JoystickAdapter : AbstractInputDeviceAdapter
    {
        private readonly Dictionary<int, JoystickDeviceAdapter> _joysticks =
            new Dictionary<int, JoystickDeviceAdapter>();


        public void OnJoystickConnected(object sender, JoystickConnectedEventArguments args)
        {
            GetOrCreateDeviceAdapter(args);
        }

        public void OnJoystickDisconnected(object sender, JoystickDisconnectedEventArguments args)
        {
            Page?.OnJoystickDisconnected(sender, args);

            _joysticks.Remove(args.JoystickID);
        }

        public override void AssignSubscriber(IInputSubscriber page)
        {
            base.AssignSubscriber(page);

            foreach (var joystickDeviceAdapter in _joysticks) joystickDeviceAdapter.Value.AssignPage(Page);
        }

        public override void ReleaseSubscriber(IInputSubscriber page)
        {
            if (Page != null)
                foreach (var joystickDeviceAdapter in _joysticks)
                    joystickDeviceAdapter.Value.ReleasePage(Page);
            base.ReleaseSubscriber(page);
        }

        public override void OnFocusLost()
        {
            if (Page != null)
                foreach (var joystickDeviceAdapter in _joysticks)
                    joystickDeviceAdapter.Value.OnFocusLost();
        }

        private JoystickDeviceAdapter GetOrCreateDeviceAdapter(JoystickEventArguments args)
        {
            JoystickDeviceAdapter state;
            if (!_joysticks.TryGetValue(args.JoystickID, out state))
            {
                state = new JoystickDeviceAdapter(args);
                if (Page != null)
                    state.AssignPage(Page);
                _joysticks.Add(args.JoystickID, state);

                Page?.OnJoystickConnected(this, new JoystickConnectedEventArguments(args));
            }

            return state;
        }

        public void OnJoystickButtonDown(object sender, JoystickButtonDownEventArguments args)
        {
            GetOrCreateDeviceAdapter(args).OnJoystickButtonDown(args);
        }

        public void OnJoystickButtonUp(object sender, JoystickButtonUpEventArguments args)
        {
            GetOrCreateDeviceAdapter(args).OnJoystickButtonUp(args);
        }

        public void OnJoystickButtonCancel(object sender, JoystickButtonCancelEventArguments args)
        {
            GetOrCreateDeviceAdapter(args).OnJoystickButtonCancel(args);
        }

        public void OnJoystickAxisMove(object sender, JoystickAxisMoveEventArguments args)
        {
            if (Page == null)
                return;

            GetOrCreateDeviceAdapter(args).OnJoystickAxisMove(args);
        }

        public void OnJoystickHatMove(object sender, JoystickHatMoveEventArguments args)
        {
            if (Page == null)
                return;

            GetOrCreateDeviceAdapter(args).OnJoystickHatMove(args);
        }
    }
}