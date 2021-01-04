using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Case06_DivisionCalculator
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int _dividedNum;
        public int _divisionNum;
        public int _result;
        
        public CalculateCommand CalculateCommand { get; set; }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ViewModel()
        {
            CalculateCommand = new CalculateCommand(this);
        }

        public int DividedNum
        {
            get { return _dividedNum; }
            set
            {
                _dividedNum = value;
                RaisePropertyChanged(nameof(DividedNum));
            }
        }

        public int DivisionNum
        {
            get { return _divisionNum; }
            set
            {
                _divisionNum = value;
                RaisePropertyChanged(nameof(DivisionNum));
            }
        }

        public int Result
        {
            get { return _result; }
            set
            {
                _result = value;
                RaisePropertyChanged(nameof(Result));
            }
        }
    }
}
