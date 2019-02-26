using System;

namespace UrhoSharp.Input
{
    public static class ExtensionMethods
    {
        public static void MapPointer(this InputMapping mapping, Action<PointerArgs> onUpdate, Action onCancel = null)
        {
            mapping.MapPointer(new PointerActionProxy(onUpdate, onCancel));
        }

        public static void MapTouch(this InputMapping mapping, Action<TouchArgs> onStart = null,
            Action<TouchArgs> onUpdate = null, Action<TouchArgs> onComplete = null, Action onCancel = null)
        {
            mapping.MapTouch(new TouchActionProxy(onStart, onUpdate, onComplete, onCancel));
        }

        private class PointerActionProxy : IPointerAction
        {
            private readonly Action _onCancel;
            private readonly Action<PointerArgs> _onUpdate;

            public PointerActionProxy(Action<PointerArgs> onUpdate, Action onCancel = null)
            {
                _onUpdate = onUpdate;
                _onCancel = onCancel;
            }

            public void StartOrUpdate(PointerArgs value)
            {
                _onUpdate?.Invoke(value);
            }

            public void Cancel()
            {
                _onCancel?.Invoke();
            }
        }

        private class TouchActionProxy : ITouchAction
        {
            private readonly Action _onCancel;
            private readonly Action<TouchArgs> _onComplete;
            private readonly Action<TouchArgs> _onStart;
            private readonly Action<TouchArgs> _onUpdate;

            public TouchActionProxy(Action<TouchArgs> onStart = null, Action<TouchArgs> onUpdate = null,
                Action<TouchArgs> onComplete = null, Action onCancel = null)
            {
                _onStart = onStart;
                _onUpdate = onUpdate;
                _onComplete = onComplete;
                _onCancel = onCancel;
            }

            public void Start(TouchArgs value)
            {
                _onStart?.Invoke(value);
            }

            public void Update(TouchArgs value)
            {
                _onUpdate?.Invoke(value);
            }

            public void Complete(TouchArgs value)
            {
                _onComplete?.Invoke(value);
            }

            public void Cancel()
            {
                _onCancel?.Invoke();
            }
        }
    }
}