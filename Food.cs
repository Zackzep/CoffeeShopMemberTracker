using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    //Abstract class set to be child of product and parent of others
    public abstract class Food : Product
    {
        //Field
        public bool _isHeated;

        //Constructor to take fields that will be inputs on top of base constructor
        public Food(string name, decimal price, int points, bool isHeated) : base(name, price, points)
        {
            _isHeated = isHeated;
        }
        
        //String ovveride to add to product string override
        public override string ToString()
        {
            return base.ToString() + $" - Heated: {_isHeated}";
        }
    }
}
