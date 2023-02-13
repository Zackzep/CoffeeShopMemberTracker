using System;
using System.Collections.Generic;
using System.Data.Common;
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
using System.Windows.Shapes;

namespace RTC_WPF_Assignment
{
    /// <summary>
    /// Interaction logic for AddMember.xaml
    /// </summary>
    public partial class AddMember : Window
    {
        public AddMember()
        {
            InitializeComponent();

            //Populates listbox with members
            lbMembers.ItemsSource = Data.Members;
        }

       //Button to add member to collection
        private void btnAddMember_Click(object sender, RoutedEventArgs e)
        {
            //Creates variables to take infor from textboxes
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;

            //Creates variables for member type, set to null before radio buttons
            RegularMember memberRegular = null;
            GoldMember memberGold = null;

            //If-if else statements to check which radio button is selected
            if(rbRegularMember.IsChecked.Value) 
            {
                //Variable to associate radio button with RegularMember class
                memberRegular = new RegularMember(firstName, lastName);
            }
            else if(rbGoldMember.IsChecked.Value)
            {
                //Variable to associate radio button with GoldMember class
                memberGold = new GoldMember(firstName, lastName);
            }

            //Add members to observable collection via method in data class
            Data.AddMemberToCollection(memberRegular);
            Data.AddMemberToCollection(memberGold);
            
        }

        //listbox event to display transactions based on selected member
        private void lbMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Grabs listbox selected index and calls method to update to selected member based on index
            int selectedMemberIndex = lbMembers.SelectedIndex;
            Data.UpdateCurrentMember(Data.Members[selectedMemberIndex]);

            //Creates object variables based on selected member
            Member currentMember = Data.CurrentMember;
            
            //Populates listbox based on transactions of selected member by accessing previous transactions observable collection
            lbTransHistory.ItemsSource = currentMember.PreviousTransactions;

            //Updates point total in member listbox
            lbMembers.Items.Refresh();
        }
    }
}
