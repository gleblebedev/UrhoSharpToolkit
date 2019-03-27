using System;
using System.Reactive.Linq;
using GalaSoft.MvvmLight;
using UrhoSharp.Editor.Model;

namespace UrhoSharp.Editor.ViewModel
{
    public class StatusBarViewModel : ViewModelBase, IDisposable
    {
        private string _message;
        private readonly IDisposable _subscription;

        public StatusBarViewModel(IObservable<LogMessage> _messages)
        {
            _subscription = _messages.ObserveOnDispatcher().Subscribe(OnLogMessage);
        }

        public string Message
        {
            get => _message;
            set => Set(ref _message, value);
        }

        public void Dispose()
        {
            _subscription?.Dispose();
        }

        public void OnLogMessage(LogMessage msg)
        {
            Message = msg.Message;
        }
    }
}