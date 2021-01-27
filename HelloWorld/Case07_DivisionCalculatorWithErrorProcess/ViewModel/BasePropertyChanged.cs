using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Case07.ViewModel
{
    public abstract class BasePropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void SetValue<T>(T src,ref T dst,string name)
        {
            if (!src.Equals(dst))       // 同一の値でない場合イベント発行
            {
                dst = src;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
