using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    public class Lunch : Food
    {
        public bool _hasDairy;
        public bool _hasGluten;
        public bool _isCombo;

        public Lunch(bool hasDairy, bool hasGluten, bool isCombo)
        {
            _hasDairy = hasDairy;
            _hasGluten = hasGluten;
            _isCombo = isCombo;
        }
        public override string ToString()
        {
            return base.ToString() + $"{_hasDairy} - {_hasGluten} - {_isCombo}";
        }
    }
}
