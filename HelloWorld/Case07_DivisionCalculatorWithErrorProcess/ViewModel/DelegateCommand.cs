using System;
using System.Windows.Input;

namespace Case07.ViewModel
{
    internal class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public DelegateCommand(Action<object> execute,Func<object,bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke(parameter);
        }

        // これいる？？
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this,null);
        }
    }
}