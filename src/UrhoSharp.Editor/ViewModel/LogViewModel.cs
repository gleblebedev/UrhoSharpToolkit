using System;
using System.Reactive.Linq;
using UrhoSharp.Editor.Model;

namespace UrhoSharp.Editor.ViewModel
{
    public class LogViewModel
    {
        private readonly IDisposable _subscription;

        public LogViewModel(IObservable<LogMessage> _messages)
        {
            _subscription = _messages.ObserveOnDispatcher().Subscribe(OnLogMessage);
        }

        public void OnLogMessage(LogMessage msg)
        {
        }


        public void Dispose()
        {
            _subscription?.Dispose();
        }
    }
}