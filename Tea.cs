using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    //Class to be set as child of drink
    public class Tea : Drink
    {
        //Field
        public string _typeOfTea;

        //Constructor to take field as well as base(drink : product) constructor
        public Tea(string name, decimal price, int points, Size drinkSize, string typeOfTea) : base(name, price, points, drinkSize)
        {
            _typeOfTea = typeOfTea;
        }

        //String override to add to product and drink string overrides
        public override string ToString()
        {
            return base.ToString() + $" - Type: {_typeOfTea}";
        }
    }
}
