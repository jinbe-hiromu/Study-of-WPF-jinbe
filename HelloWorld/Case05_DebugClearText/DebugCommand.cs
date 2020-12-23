using System;
using System.Windows.Input;

namespace Case05_DebugClearText
{
    public class DebugCommand : ICommand
    {
        private ViewModel _viewModel;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public DebugCommand(ViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.UpperString = _viewModel.String.ToUpper();
        }
    }
}