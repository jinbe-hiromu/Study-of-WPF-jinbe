using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Case04_ConvertUpperString
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public StringModel StringModel { get; set; }
        public UpperStringModel UpperStringModel { get; set; }

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
        }

        public string String
        {
            get { return StringModel.String; }
            set 
            {
                StringModel.String = value;
                UpperString = StringModel.String.ToUpper();
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
