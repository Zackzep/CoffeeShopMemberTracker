using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    //Class set to be child of food
    public class Breakfast : Food
    {
        //Fields
        public bool _hasDairy;
        public bool _hasGluten;
        public bool _isCombo;

        //Constructor to take fields that will be inputs on top of base constructor
        public Breakfast(string name, decimal price, int points, bool isHeated, bool hasDairy, bool hasGluten, bool isCombo) : base(name, price, points, isHeated)
        {
            _hasDairy = hasDairy;
            _hasGluten = hasGluten;
            _isCombo = isCombo;
        }

        //String ovveride to add to product and food string overrides
        public override string ToString()
        {
            return base.ToString() + $" - Dairy: {_hasDairy} - Gluten: {_hasGluten} - Combo: {_isCombo}";
        }
    }
}
