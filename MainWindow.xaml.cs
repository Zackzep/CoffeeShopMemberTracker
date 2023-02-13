//Zack Zepezauer
//2-12-23
//CSI 124 MidTerm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RTC_WPF_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Populate listbox and combobox with products and members
            lbProducts.ItemsSource = Data.Products; 
            cbMembers.ItemsSource = Data.Members;
        }

        //Button to open add member window
        private void btnMemberInfo_Click(object sender, RoutedEventArgs e)
        {
            new AddMember().Show();
        }

        //Button to purchase product with $
        private void btnBuyProduct_Click(object sender, RoutedEventArgs e)
        {
            //Grabs combobox selected index and calls method to update to selected member based on index
            int selectedMemberIndex = cbMembers.SelectedIndex;
            Data.UpdateCurrentMember(Data.Members[selectedMemberIndex]);

            //Grabs listbox selected index and calls method to update to selected product based on index
            int selectedProductIndex = lbProducts.SelectedIndex;
            Data.UpdateCurrentProduct(Data.Products[selectedProductIndex]);

            //Creates object variables based on selected items
            Product product = (Product)lbProducts.SelectedItem;
            Member member = Data._members[selectedMemberIndex];

            //Method call to add points to member total
            member.AddPoints(product);

            //Method call to add product to member tansactions
            member.AddProduct(product);

            //Populates transactions listbox with each purchase based on index selected
            lbTransactions.Items.Add(Data.Products[selectedProductIndex]);

            //Updates points label with member total
            lblUserPoints.Content = $"Point Total: {member._pointAmount.ToString()}";
        }

        //Button to purchase product with points
        private void btnUsePoints_Click(object sender, RoutedEventArgs e)
        {
            //Grabs combobox selected index and calls method to update to selected member based on index
            int selectedMemberIndex = cbMembers.SelectedIndex;
            Data.UpdateCurrentMember(Data.Members[selectedMemberIndex]);

            //Grabs listbox selected index and calls method to update to selected product based on index
            int selectedProductIndex = lbProducts.SelectedIndex;
            Data.UpdateCurrentProduct(Data.Products[selectedProductIndex]);

            //Creates object variables based on selected items
            Product product = (Product)lbProducts.SelectedItem;
            Member member = Data._members[selectedMemberIndex];

            //Method call to take points from member total
            member.DeductPoints(product);

            //Method call to add product to member tansactions
            member.AddProduct(product);

            //Populates transactions listbox with each purchase based on index selected
            lbTransactions.Items.Add(Data.Products[selectedProductIndex]);

            //Updates points label with member total
            lblUserPoints.Content = $"Point Total: {member._pointAmount.ToString()}";
        }

        //Button to open add product window
        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            new AddProduct().Show();
        }

        //Clears transactions when new member selected
        private void cbMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Grabs combobox selected index and calls method to update to selected member based on index
            int selectedMemberIndex = cbMembers.SelectedIndex;
            Data.UpdateCurrentMember(Data.Members[selectedMemberIndex]);

            //Updates point total in member combobox
            cbMembers.Items.Refresh();

            //Clears transactions listbox when different member selected
            lbTransactions.Items.Clear();
        }
    }
}
