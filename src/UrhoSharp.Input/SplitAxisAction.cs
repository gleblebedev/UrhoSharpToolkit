namespace UrhoSharp.Input
{
    public class SplitAxisAction : ITriggerAction
    {
        private readonly ITriggerAction _negative;
        private readonly ITriggerAction _positive;
        private float _negativeValue;

        private float _positiveValue;

        public SplitAxisAction(ITriggerAction positive, ITriggerAction negative)
        {
            _positive = positive;
            _negative = negative;
        }

        private float Value
        {
            set
            {
                var pos = value;
                var neg = -value;
                if (pos < 0.0f) pos = 0.0f;
                if (neg < 0.0f) neg = 0.0f;
                if (_positiveValue != pos)
                {
                    _positiveValue = pos;
                    _positive.StartOrUpdate(pos);
                }

                if (_negativeValue != neg)
                {
                    _negativeValue = neg;
                    _negative.StartOrUpdate(neg);
                }
            }
        }

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
    }
}