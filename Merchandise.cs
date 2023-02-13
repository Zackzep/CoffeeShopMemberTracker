using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    //Abstract class to be child of product and parent of others
    public abstract class Merchandise : Product
    {
        //Constructor to connect classes
        public Merchandise(string name, decimal price, int points) : base(name, price, points)
        {
        }
    }
}
