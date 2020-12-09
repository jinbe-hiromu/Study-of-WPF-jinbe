using System;
using System.Collections.Generic;
using System.Text;
using Reactive.Bindings;

namespace HelloWorld
{
    class MainViewModel
    {
        MainModel model = new MainModel();

        public ReactiveProperty<string> Text { get; private set; }

        public object TextRead(object dataContext)
        {
            this.Text = model.Text;
            dataContext = this;
            return dataContext;
        }

    }
}
