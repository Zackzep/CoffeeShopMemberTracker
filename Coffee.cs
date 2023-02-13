using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    //Class to be set as child of drink
    public class Coffee : Drink
    {
        //Field
        public string _typeOfRoast;

        //Constructor to take field as well as base(drink : product) constructor
        public Coffee(string name, decimal price, int points, Size drinkSize, string typeOfRoast) : base(name, price, points, drinkSize)
        {
            _typeOfRoast = typeOfRoast;
        }

        //String override to add to product and drink string overrides
        public override string ToString()
        {
            return base.ToString() + $" - Roast: {_typeOfRoast}";
        }
    }
}
