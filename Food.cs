using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    abstract public class Food : Product
    {
        public bool _isHeated;

        public Food(bool isHeated)
        {
            _isHeated = isHeated;
        }
    }
}
