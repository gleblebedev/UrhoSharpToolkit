using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class UrhoRef<T> where T : RefCounted
    {
        private T _value;

        public UrhoRef()
        {
        }

        public UrhoRef(T value)
        {
            Value = value;
        }

        public T Value
        {
            get => _value;
            set => Set(value);
        }

        public bool HasValue => _value != null;

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        private void ReleaseUnmanagedResources()
        {
            Reset();
        }

        ~UrhoRef()
        {
            Application.InvokeOnMain(() => ReleaseUnmanagedResources());
        }

        public bool Set(T value)
        {
            if (_value == value)
                return false;
            if (_value != null) _value.ReleaseRef();
            _value = value;
            if (_value != null) _value.AddRef();

            return true;
        }

        public void Reset()
        {
            Set(null);
        }

        public override string ToString()
        {
            if (_value == null)
                return "<null>";
            return _value.ToString();
        }
    }
}