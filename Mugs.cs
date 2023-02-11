using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    public class Mugs : Merchandise
    {
        public string _design;

        public Mugs(string design)
        {
            _design = design;
        }
        public override string ToString()
        {
            return base.ToString() + $"{_design}";
        }
    }
}
