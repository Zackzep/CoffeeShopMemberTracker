using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    abstract public class Product
    {
        public string _name;
        public string _price;
        public int _points;
        public string _sku;
        static int _numberOfProduct;

        public Product(string name, string price, int points)
        {
            Random rand = new Random();
            
            _name = name;
            _price = price;
            _points = points;
            _sku = rand.Next(1000000, 10000000).ToString();
            _numberOfProduct++;
        }
        public override string ToString()
        {
            //return $"{GetType().Name} - {_name} {_price} - Balance {Balance.ToString("c")}";
            return $"{GetType()} - {_sku} - {_name} - {_price} - {_points}";
        }
    }
}
