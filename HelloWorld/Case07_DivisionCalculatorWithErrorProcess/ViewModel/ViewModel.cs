using Case07.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Case07.ViewModel
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public UserNotificationObject UserNotificationObject { get; } = new UserNotificationObject();

        public decimal DividedNum { get; set; }

        public decimal DivisionNum { get; set; }

        private decimal _result;

        public decimal Result
        {
            get { return _result; }
            set
            {
                _result = value;
                RaisePropertyChanged(nameof(Result));
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private DelegateCommand _calcCommand;

        public ICommand CalcCommand
        {
            get 
            {
                return _calcCommand ??= new DelegateCommand(TryDivide, _ => true);
            }
        }

        private void TryDivide(object obj)
        {
            try
            {
                Result = new Divider(DividedNum, DivisionNum).Execute();
            }
            catch(Exception e)
            {
                UserNotificationObject.NotifyError(e.Message);
            }
        }
    }
}
