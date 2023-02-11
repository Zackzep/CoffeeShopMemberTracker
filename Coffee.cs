using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    public class Coffee : Drink
    {
        public string _typeOfRoast;

        public Coffee(string typeOfRoast)
        {
            _typeOfRoast = typeOfRoast;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Roast {_typeOfRoast}";
        }
    }
}
