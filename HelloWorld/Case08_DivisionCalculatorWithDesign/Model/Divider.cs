using System;
using System.Collections.Generic;
using System.Text;

namespace Case08.Model
{
    public class Divider
    {
        private readonly decimal _devisionNum;
        private readonly decimal _deviedNum;

        public Divider(decimal devisionNum,decimal deviedNum)
        {
            _devisionNum = devisionNum;
            _deviedNum = deviedNum;
        }

        public decimal Execute()
        {
            return _deviedNum / _devisionNum;
        }
    }
}
