using System.Collections.Generic;
using Urho;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Pages.InputDeviceAdapters
{
    public class KeyboardAdapter : AbstractInputDeviceAdapter
    {
        private readonly Dictionary<Key, KeyDownEventArguments> _pressedKeys =
            new Dictionary<Key, KeyDownEventArguments>();


        public void OnKeyUp(object sender, KeyUpEventArguments args)
        {
            if (Page == null)
                return;

            KeyDownEventArguments prevArgs;
            if (!_pressedKeys.TryGetValue(args.Key, out prevArgs))
                return;

            _pressedKeys.Remove(args.Key);
            Page.OnKeyUp(sender, args);
        }

        public void OnKeyDown(object sender, KeyDownEventArguments args)
        {
            if (Page == null)
                return;
            _pressedKeys[args.Key] = args;
            Page.OnKeyDown(sender, args);
        }

        public void OnKeyCancel(object sender, KeyCancelEventArguments args)
        {
            if (Page == null)
                return;

            KeyDownEventArguments prevArgs;
            if (!_pressedKeys.TryGetValue(args.Key, out prevArgs))
                return;

            _pressedKeys.Remove(args.Key);
            Page.OnKeyCancel(sender, args);
        }

        public override void OnFocusLost()
        {
            if (Page != null)
            {
                foreach (var argument in _pressedKeys)
                    Page.OnKeyCancel(this, new KeyCancelEventArguments(argument.Value));
                _pressedKeys.Clear();
            }
        }
    }
}