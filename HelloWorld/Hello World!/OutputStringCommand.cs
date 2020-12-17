using System;
using System.Windows.Input;

namespace Hello_World_
{
    public class OutputStringCommand : ICommand
    {
        private ViewModel viewModel;

        public OutputStringCommand(ViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(string.IsNullOrEmpty(viewModel.String))
            {
                viewModel.String = "Hello world";
            }
            else
            {
                viewModel.String = "";
            }
        }
    }
}