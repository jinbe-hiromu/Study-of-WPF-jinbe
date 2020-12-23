using System;
using System.Windows.Input;

namespace Case05_DebugClearText
{
    public class ClearCommand : ICommand
    {
        private ViewModel _viewModel;

        public ClearCommand(ViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.String = "";
            _viewModel.UpperString = "";
        }
    }
}