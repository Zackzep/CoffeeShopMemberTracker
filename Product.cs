using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    //Abstract class set to be parent of others
    public abstract class Product
    {
        //Fields
        public string _name;
        public decimal _price;
        public int _points;
        public string _sku;
        static int _numberOfProduct;

        //Constructor to take fields that will be inputs
        public Product(string name, decimal price, int points)
        {
            //Generate random
            Random rand = new Random();
            
            _name = name;
            _price = price;
            _points = points;
            //Greate random sku
            _sku = rand.Next(1000000, 10000000).ToString();
            //Increase product count with each one created
            _numberOfProduct++;
        }

        //String override to fill product info when displayed
        public override string ToString()
        {
            return $"{GetType().Name} - Sku: {_sku} - Item: {_name} - Cost: {_price.ToString("c")} - Points: {_points}";
        }
    }
}
