using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    public class Tea : Drink
    {
        public string _typeOfTea;

        public Tea(string typeOfTea)
        {
            _typeOfTea = typeOfTea;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Type {_typeOfTea}";
        }
    }
}
