using System;
using System.Reactive.Concurrency;
using Urho;

namespace UrhoSharp.Rx
{
    public sealed class UrhoScheduler : IUrhoScheduler, IDisposable
    {
        private readonly SchedulerImpl _impl;
        private bool _isDisposed;

        public UrhoScheduler()
        {
            _impl = new SchedulerImpl();
            Step();
        }

        public void Dispose()
        {
            _isDisposed = true;
        }

        public IDisposable Schedule<TState>(TState state, Func<IScheduler, TState, IDisposable> action)
        {
            CheckIfDisposed();
            return _impl.Schedule(state, action);
        }

        public IDisposable Schedule<TState>(TState state, TimeSpan dueTime,
            Func<IScheduler, TState, IDisposable> action)
        {
            CheckIfDisposed();
            return _impl.Schedule(state, dueTime, action);
        }

        public IDisposable Schedule<TState>(TState state, DateTimeOffset dueTime,
            Func<IScheduler, TState, IDisposable> action)
        {
            CheckIfDisposed();
            return _impl.Schedule(state, dueTime, action);
        }

        public DateTimeOffset Now => _impl.Now;

        private void Step()
        {
            Application.InvokeOnMain(Step);
            if (!_isDisposed) _impl.AdvanceTo(DateTimeOffset.Now);
        }

        private void CheckIfDisposed()
        {
            if (_isDisposed) throw new InvalidOperationException("Scheduler is disposed");
        }

        internal class SchedulerImpl : VirtualTimeScheduler<DateTimeOffset, long>
        {
            /// <summary>
            ///     Adds a relative virtual time to an absolute virtual time value.
            /// </summary>
            /// <param name="absolute">Absolute virtual time value.</param>
            /// <param name="relative">Relative virtual time value to add.</param>
            /// <returns>Resulting absolute virtual time sum value.</returns>
            protected override DateTimeOffset Add(DateTimeOffset absolute, long relative)
            {
                return absolute.AddTicks(relative);
            }

            /// <summary>
            ///     Converts the absolute virtual time value to a DateTimeOffset value.
            /// </summary>
            /// <param name="absolute">Absolute virtual time value to convert.</param>
            /// <returns>Corresponding DateTimeOffset value.</returns>
            protected override DateTimeOffset ToDateTimeOffset(DateTimeOffset absolute)
            {
                return absolute;
            }

            /// <summary>
            ///     Converts the TimeSpan value to a relative virtual time value.
            /// </summary>
            /// <param name="timeSpan">TimeSpan value to convert.</param>
            /// <returns>Corresponding relative virtual time value.</returns>
            protected override long ToRelative(TimeSpan timeSpan)
            {
                return timeSpan.Ticks;
            }
        }
    }
}