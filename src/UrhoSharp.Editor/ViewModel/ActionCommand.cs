using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UrhoSharp.Editor.ViewModel
{
    public class ActionCommand : ICommand
    {
        private readonly Action _callback;

        public ActionCommand(Action callback)
        {
            _callback = callback;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _callback();
        }

        public event EventHandler CanExecuteChanged;
    }

    public class ActionCommand<T> : ICommand
    {
        private readonly Action<T> _callback;

        public ActionCommand(Action<T> callback)
        {
            _callback = callback;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _callback((T) parameter);
        }

        public event EventHandler CanExecuteChanged;
    }

    public class AsyncCommand : ICommand
    {
        private readonly Func<Task> _callback;

        public AsyncCommand(Func<Task> callback)
        {
            _callback = callback;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Task.Run(_callback);
        }

        public event EventHandler CanExecuteChanged;
    }
}