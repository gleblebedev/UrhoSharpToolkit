using System;
using System.Reactive.Concurrency;

namespace UrhoSharp.Rx
{
    public sealed class UrhoManualScheduler : IUrhoScheduler
    {
        private readonly SchedulerImpl _impl;

        public UrhoManualScheduler()
        {
            _impl = new SchedulerImpl();
        }

        public IDisposable Schedule<TState>(TState state, Func<IScheduler, TState, IDisposable> action)
        {
            return _impl.Schedule(state, action);
        }

        public IDisposable Schedule<TState>(TState state, TimeSpan dueTime,
            Func<IScheduler, TState, IDisposable> action)
        {
            return _impl.Schedule(state, dueTime, action);
        }

        public IDisposable Schedule<TState>(TState state, DateTimeOffset dueTime,
            Func<IScheduler, TState, IDisposable> action)
        {
            return _impl.Schedule(state, dueTime, action);
        }

        public DateTimeOffset Now => _impl.Now;

        public void Update(float timeStep)
        {
            _impl.Update(timeStep);
        }

        internal class SchedulerImpl : VirtualTimeScheduler<double, double>
        {
            private double _lastKnowAbsoluteValue;
            private DateTimeOffset _lastKnowTime;

            public SchedulerImpl()
            {
                _lastKnowTime = DateTimeOffset.Now;
                _lastKnowAbsoluteValue = 0.0;
            }

            /// <summary>
            ///     Adds a relative virtual time to an absolute virtual time value.
            /// </summary>
            /// <param name="absolute">Absolute virtual time value.</param>
            /// <param name="relative">Relative virtual time value to add.</param>
            /// <returns>Resulting absolute virtual time sum value.</returns>
            protected override double Add(double absolute, double relative)
            {
                return absolute + relative;
            }

            /// <summary>
            ///     Converts the absolute virtual time value to a DateTimeOffset value.
            /// </summary>
            /// <param name="absolute">Absolute virtual time value to convert.</param>
            /// <returns>Corresponding DateTimeOffset value.</returns>
            protected override DateTimeOffset ToDateTimeOffset(double absolute)
            {
                return _lastKnowTime.Add(TimeSpan.FromSeconds(absolute - _lastKnowAbsoluteValue));
            }

            /// <summary>
            ///     Converts the TimeSpan value to a relative virtual time value.
            /// </summary>
            /// <param name="timeSpan">TimeSpan value to convert.</param>
            /// <returns>Corresponding relative virtual time value.</returns>
            protected override double ToRelative(TimeSpan timeSpan)
            {
                return timeSpan.TotalSeconds;
            }

            public void Update(float timeStep)
            {
                _lastKnowTime = DateTimeOffset.Now;
                _lastKnowAbsoluteValue += timeStep;
                AdvanceBy(timeStep);
            }
        }
    }
}