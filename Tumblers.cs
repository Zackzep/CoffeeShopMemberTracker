using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    public class Tumblers : Merchandise
    {
        public string _color;

        public Tumblers(string color)
        {
            _color = color;
        }

        public override string ToString()
        {
            return base.ToString() + $"{_color}";
        }
    }
}
