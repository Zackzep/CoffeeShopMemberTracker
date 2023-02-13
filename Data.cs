using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    class Data
    {
        //Static fields to connect data class with the rest of project(members and products collections, and
        //current fields to work with updating in events)
        public static ObservableCollection<Member> _members;
        public static ObservableCollection<Product> _products;
        public static Member _currentMember = null;
        public static Product _currentProduct = null;

        //Static constructor
        static Data()
        {
            //Instantiate observable collections in constructor
            _members = new ObservableCollection<Member>();
            _products = new ObservableCollection<Product>();
        }

        //Properties -- only get Members and Products so they can't be changed, but have set for current so they can be manipulated
        //in events
        public static ObservableCollection<Member> Members { get => _members; }
        public static ObservableCollection<Product> Products { get => _products; }
        public static Member CurrentMember { get => _currentMember; set => _currentMember = value; }
        public static Product CurrentProduct { get => _currentProduct; set => _currentProduct = value;  }

        //Method to add product to collection
        public static void AddProductToCollection(Product product)
        {
            _products.Add(product);
        }

        //Method to add member to collection
        public static void AddMemberToCollection(Member member)
        {
            _members.Add(member);
        }

        //Selected index methods used for updating products and members based on selection
        public static void UpdateCurrentProduct(Product product)
        {
            //Takes product and sets it as current product
            _currentProduct = product;
        }
        public static void UpdateCurrentMember(Member member)
        {
            //Takes member and sets it as current member
            _currentMember = member;
        }

        
    }
}
