using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Case09_ProviderListUsingDataGrid.ViewModel
{
    public abstract class BasePropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void SetValue<T>(T src, ref T dst, [CallerMemberName] string name = null)
        {
            if (!src.Equals(dst))       // 同一の値でない場合イベント発行
            {
                dst = src;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
