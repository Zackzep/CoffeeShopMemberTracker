using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RTC_WPF_Assignment
{
    //Abstract class to be set as child of product but also parent of others
    public abstract class Drink : Product
    {
        //Generate enumerator and create field for it
        public enum Size { Short, Tall, Grade, Venti, Trenta }
        Size _drinkSize;

        //Constructor to take drink size as well as base(product) constructor
        public Drink(string name, decimal price, int points, Size drinkSize) : base(name, price, points)
        {
            _drinkSize = drinkSize;
        }
        
        //String override to add to product string override
        public override string ToString()
        {
            return base.ToString() + $" - Size: {_drinkSize}";
        }
    }
}
