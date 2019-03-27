using System.ComponentModel;
using UrhoSharp.Input.Annotations;

namespace UrhoSharp.Input
{
    public class AxisAction : ITriggerAction, INotifyPropertyChanged
    {
        private float _value;

        public float Value
        {
            get => _value;
            private set
            {
                if (_value != value)
                {
                    _value = value;
                    OnPropertyChanged(nameof(Value));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public void StartOrUpdate(float value)
        {
            Value = value;
        }

        public void Stop()
        {
            Value = 0.0f;
        }

        public void Cancel()
        {
            Value = 0.0f;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}