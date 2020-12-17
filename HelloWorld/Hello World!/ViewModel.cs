using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hello_World_
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public StringModel StringModel { get; set; }
        public OutputStringCommand OutputStringCommand { get; private set; }

        public ViewModel()
        {
            OutputStringCommand = new OutputStringCommand(this);
            StringModel = new StringModel();
        }

        public string String
        {
            get { return StringModel.String; }
            set
            {
                StringModel.String = value;

                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("String"));
                }
            }
        }

    }
}
