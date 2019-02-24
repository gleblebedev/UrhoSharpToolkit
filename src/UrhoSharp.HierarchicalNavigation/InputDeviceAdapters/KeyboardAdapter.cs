using System.Collections.Generic;
using Urho;
using UrhoSharp.Interfaces;

namespace UrhoSharp.HierarchicalNavigation.InputDeviceAdapters
{
    public class KeyboardAdapter : AbstractInputDeviceAdapter
    {
        private readonly Dictionary<Key, KeyDownEventArguments> _pressedKeys =
            new Dictionary<Key, KeyDownEventArguments>();

        public KeyboardAdapter(IInput input) : base(input)
        {
            Input.KeyDown += OnKeyDown;
            Input.KeyUp += OnKeyUp;
        }

        private void OnKeyUp(object sender, KeyUpEventArguments args)
        {
            if (Page == null)
                return;

            KeyDownEventArguments prevArgs;
            if (!_pressedKeys.TryGetValue(args.Key, out prevArgs))
                return;

            _pressedKeys.Remove(args.Key);
            Page.OnKeyUp(sender, args);
        }

        private void OnKeyDown(object sender, KeyDownEventArguments args)
        {
            if (Page == null)
                return;
            _pressedKeys[args.Key] = args;
            Page.OnKeyDown(sender, args);
        }

        public override void ReleasePage(IScenePage page)
        {
            foreach (var argument in _pressedKeys) page.OnKeyCancel(this, new KeyCancelEventArguments(argument.Value));
            _pressedKeys.Clear();
            base.ReleasePage(page);
        }

        public override void Dispose()
        {
            Input.KeyDown -= OnKeyDown;
            Input.KeyUp -= OnKeyUp;
        }
    }
}