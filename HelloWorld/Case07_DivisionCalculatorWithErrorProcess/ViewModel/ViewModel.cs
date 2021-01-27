using Case07.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Case07.ViewModel
{
    public class ViewModel : BasePropertyChanged
    {
        public UserNotificationObject UserNotificationObject { get; } = new UserNotificationObject();

        public decimal DividedNum { get; set; }

        public decimal DivisionNum { get; set; }

        private decimal _result;

        public decimal Result
        {
            get { return _result; }
            set { SetValue(value, ref _result, nameof(Result)); }
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
                Result = new Divider(DivisionNum, DividedNum).Execute();
            }
            catch(Exception e)
            {
                UserNotificationObject.NotifyError(e.Message);
            }
        }
    }
}
