using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    //Class to be child of merchandise
    public class Tumblers : Merchandise
    {
        //Field
        public string _color;

        //Constructor to take field that will be inputs on top of base constructor
        public Tumblers(string name, decimal price, int points, string color) : base(name, price, points)
        {
            _color = color;
        }

        //String override to add to product string override
        public override string ToString()
        {
            return base.ToString() + $" - Color: {_color}";
        }
    }
}
