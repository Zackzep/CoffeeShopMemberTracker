using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    public class GiftCard : Product
    {
        public decimal _amount;

        public GiftCard(decimal amount)
        {
            _amount = amount;
        }
        public override string ToString()
        {
            return base.ToString() + $"{_amount}";
        }
    }
}
