using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    //class set to be child of product
    public class GiftCard : Product
    {
        //Field
        public decimal _amount;

        //Constructor to take field that will be input on top of base constructor
        public GiftCard(string name, decimal price, int points, decimal amount) : base(name, price, points)
        {
            _amount = amount;
        }

        //String ovveride to add to product string override
        public override string ToString()
        {
            return base.ToString() + $" - Value: {_amount.ToString("c")}";
        }
    }
}
