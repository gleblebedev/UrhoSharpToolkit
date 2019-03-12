using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using UrhoSharp.Editor.Model;

namespace UrhoSharp.Editor.ViewModel
{
    public class LogViewModel
    {
        private IDisposable _subscription;

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
