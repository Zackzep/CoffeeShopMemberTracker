using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    //Class to be child of merchandise
    public class Mugs : Merchandise
    {
        //Field
        public string _design;

        //Constructor to take field that will be inputs on top of base constructor
        public Mugs(string name, decimal price, int points, string design) : base(name, price, points)
        {
            _design = design;
        }

        //String override to add to product string override
        public override string ToString()
        {
            return base.ToString() + $" - Design: {_design}";
        }
    }
}
