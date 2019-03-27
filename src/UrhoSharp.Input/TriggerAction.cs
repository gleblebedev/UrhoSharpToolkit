using System.ComponentModel;
using UrhoSharp.Input.Annotations;

namespace UrhoSharp.Input
{
    public class TriggerAction : ITriggerAction, INotifyPropertyChanged
    {
        private bool _value;

        public TriggerAction(float threshold = 0.5f)
        {
            Threshold = threshold;
        }

        public bool Value
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

        public float Threshold { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void StartOrUpdate(float value)
        {
            Value = value > Threshold;
        }

        public void Stop()
        {
            Value = false;
        }

        public void Cancel()
        {
            Value = false;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}