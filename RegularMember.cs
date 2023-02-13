using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    //Class set to child of member
    public class RegularMember : Member
    {
        public RegularMember(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        //Method to deduct points from member
        public override int DeductPoints(Product product)
        {
            //Member point amount minus product points 
            int points = (int)(_pointAmount -= product._points);

            //Return points
            return points;

        }

        //Method to add points to member
        public override int AddPoints(Product product)
        {
            //Member point amount plus product points 
            int points = (int)(_pointAmount += product._points);

            //Return points
            return points;
        }
    }
}
