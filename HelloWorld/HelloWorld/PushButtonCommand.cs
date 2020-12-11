using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace HelloWorld
{
    class PushButtonCommand : ICommand
    {
        private readonly MainViewModel _viewModel;

        public PushButtonCommand(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.Count++;
        }
    }
}
