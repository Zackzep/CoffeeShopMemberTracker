using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    //Class set to child of member
    public class GoldMember : Member
    {
        public GoldMember(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        //Method to deduct points from member
        public override int DeductPoints(Product product)
        {
            //Member point amount minus product points set to half for gold member
            int points = ((int)(_pointAmount -= (product._points * .5)));

            //Return points
            return points;
        }

        //Method to add points to member
        public override int AddPoints(Product product)
        {
            //Member point amount plus product points set to 150% for gold member
            int points = (int)(_pointAmount += (product._points * 1.5));

            //Return points
            return points;
        }
    }
}
