using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    //Abstract class set up to interact with child classes
    public abstract class Member
    {
        //Fields
        public string _firstName;
        public string _lastName;
        public string _memberNumber;
        public double _pointAmount;
        public DateTime _memberSince;
        //Special field to create a product collection based on transactions made
        public ObservableCollection<Product> _previousTransactions;

        //Constructor to take member name
        public Member(string firstName, string lastName)
        {
            //Generate random
            Random rand2 = new Random();
            
            _firstName = firstName;
            _lastName = lastName;

            //Create random for member number
            _memberNumber = rand2.Next(1000000, 10000000).ToString();
            //Set points to 0
            _pointAmount = 0;
            //Generate time of member creation based on current time
            _memberSince = DateTime.Now;
            //Instantiate transactions collection
            _previousTransactions = new ObservableCollection<Product>();
        }
        
        //Properties--get and set for points so they can be adjusted, only set for transactions so it cant
        public double PointAmount { get => _pointAmount; set => _pointAmount = value; }
        public ObservableCollection<Product> PreviousTransactions { get => _previousTransactions; }

        //String override to fill member info when displayed
        public override string ToString()
        {
            return $"{GetType().Name} - Name: {_firstName}  {_lastName} - Points: {_pointAmount} - Member ID: {_memberNumber} Member Since: {_memberSince}";
        }

        //Add product to transactions method
        public void AddProduct(Product product)
        {
            _previousTransactions.Add(product);
        }
        
        //Abstract methods to deduct points from member total(connected to methods in gold and regular classes)
        public abstract int DeductPoints(Product product);

        public abstract int AddPoints(Product product);

    }
}
