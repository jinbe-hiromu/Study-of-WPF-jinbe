using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Case05_DebugClearText
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public StringModel StringModel { get; set; }
        public UpperStringModel UpperStringModel { get; set; }
        public DebugCommand DebugCommand { get; private set; }
        public ClearCommand ClearCommand { get; private set; }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ViewModel()
        {
            StringModel = new StringModel();
            UpperStringModel = new UpperStringModel();
            DebugCommand = new DebugCommand(this);
            ClearCommand = new ClearCommand(this);
        }

        public string String
        {
            get { return StringModel.String; }
            set
            {
                StringModel.String = value;
                RaisePropertyChanged("String");
            }
        }

        public string UpperString
        {
            get { return UpperStringModel.String; }
            set
            {
                UpperStringModel.String = value;
                RaisePropertyChanged("UpperString");
            }
        }
    }
}
