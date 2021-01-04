using System;
using System.Windows.Input;

namespace Case06_DivisionCalculator
{
    public class CalculateCommand : ICommand
    {
        private ViewModel _viewModel;

        public event EventHandler CanExecuteChanged;

        public CalculateCommand(ViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.Result = _viewModel.DividedNum / _viewModel.DivisionNum;
        }
    }
}