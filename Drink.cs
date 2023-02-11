using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    abstract public class Drink : Product
    {
        public enum Size { Short, Tall, Grade, Venti, Trenta }
        
        Size _drinkSize;

        public override Drink(Size drinkSize)
        {
            _drinkSize = drinkSize;
        }
    }
}
