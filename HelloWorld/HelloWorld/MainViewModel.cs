using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Reactive.Bindings;

namespace HelloWorld
{
    class MainViewModel : INotifyPropertyChanged
    {
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Count"));
                }
            }
        }

        public ICommand PushButtonCommand
        {
            get
            {
                if (_pushButtonCommand == null)
                {
                    _pushButtonCommand = new PushButtonCommand(this);
                }
                return _pushButtonCommand;
            }
        }

        private int _count;

        private ICommand _pushButtonCommand;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
