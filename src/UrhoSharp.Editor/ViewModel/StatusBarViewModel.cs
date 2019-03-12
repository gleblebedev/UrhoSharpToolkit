using System;
using System.Reactive.Linq;
using GalaSoft.MvvmLight;
using UrhoSharp.Editor.Model;

namespace UrhoSharp.Editor.ViewModel
{
    public class StatusBarViewModel : ViewModelBase, IDisposable
    {
        private IDisposable _subscription;
        private string _message;

        public StatusBarViewModel(IObservable<LogMessage> _messages)
        {
            _subscription = _messages.ObserveOnDispatcher().Subscribe(OnLogMessage);
        }

        public void OnLogMessage(LogMessage msg)
        {
            Message = msg.Message;
        }

        public string Message
        {
            get => _message;
            set => Set(ref _message , value);
        }

        public void Dispose()
        {
            _subscription?.Dispose();
        }
    }
}