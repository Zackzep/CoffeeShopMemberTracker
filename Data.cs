using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RTC_WPF_Assignment
{
    public class Data
    {
        static ObservableCollection<Member> _members;
        static ObservableCollection<Product> _products;
        static Member currentMember = null;
        static Product currentProduct = null;

        static Data()
        {
            Members = new ObservableCollection<Member>();
            Products = new ObservableCollection<Product>();
        }

        public static ObservableCollection<Member> Members { get => _members; }
        public static ObservableCollection<Product> Products { get => _products; }
        public static Member CurrentMember { get => currentMember; }
        public static Product CurrentProduct { get => currentProduct; }

        public void AddProductToCollection(Product)
        {
            _products.Add(currentProduct);
        }
        public void AddMemberToCollection(Member)
        {
            _members.Add(currentMember);
        }
        public void UpdateCurrentProduct(Product)
        {

        }
        public void UpdateCurrentMember(Member)
        {

        }
    }
}
