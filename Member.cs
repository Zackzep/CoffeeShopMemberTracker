using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    abstract public class Member
    {
        public string _firstName;
        public string _lastName;
        public string _memberNumber;
        public int _pointAmount;
        public DateTime _memberSince;

        protected Member(string firstName, string lastName)
        {
            Random rand2 = new Random();
            
            _firstName = firstName;
            _lastName = lastName;
            _memberNumber = rand2.Next(1000000, 10000000).ToString();
            _pointAmount = 0;
            _memberSince = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{GetType()} - {_firstName} - {_lastName} - {_pointAmount} - {_memberNumber}";
        }
        public int DeductPoints(Product)
        {
            _pointAmount -= 
        }
        public int AddPoints(Product)
        {
            _pointAmount +=
        }
    }
}
