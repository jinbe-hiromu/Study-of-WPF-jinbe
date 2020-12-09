using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class MainModel
    {
        public ReactiveProperty<string> Text { get; private set; } = new ReactiveProperty<string>();

        public MainModel()
        {
            Text.Value = "Hello World!!";
        }

    }
}
