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
using System.Windows.Shapes;

namespace RTC_WPF_Assignment
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();

            //Method call to populate drink sizes
            PopulateSizeComboBox();

            //Populate listbox with created products
            lbProductsList.ItemsSource = Data.Products;
        }

        //Button method to add coffee to product observable collection
        private void btnCoffee_Click(object sender, RoutedEventArgs e)
        {
            //Create variables to take info from various inputs
            string name = tbProductName.Text;
            decimal price = decimal.Parse(tbProductPrice.Text);
            int points = int.Parse(tbProductPoints.Text);
            Coffee.Size size = (Coffee.Size)cbDrinkSize.SelectedIndex;
            string typeTeaRoast = tbCoffeeTeaType.Text;

            //Create object variable to take info and create new object
            Drink newCoffee = new Coffee(name, price, points, size, typeTeaRoast);
            
            //Add object to observable collection via method call
            Data.AddProductToCollection(newCoffee);
            
        }

        //Button method to add tea to product observable collection
        private void btnTea_Click(object sender, RoutedEventArgs e)
        {
            //Create variables to take info from various inputs
            string name = tbProductName.Text;
            decimal price = decimal.Parse(tbProductPrice.Text);
            int points = int.Parse(tbProductPoints.Text);
            Tea.Size size = (Tea.Size)cbDrinkSize.SelectedIndex;
            string typeTeaRoast = tbCoffeeTeaType.Text;

            //Create object variable to take info and create new object
            Drink newTea = new Tea(name, price, points, size, typeTeaRoast);

            //Add object to observable collection via method call
            Data.AddProductToCollection(newTea);
        }

        //Button method to add a lunch to product observable collection
        private void btnLunch_Click(object sender, RoutedEventArgs e)
        {
            //Create variables to take info from various inputs
            string name = tbProductName.Text;
            decimal price = decimal.Parse(tbProductPrice.Text);
            int points = int.Parse(tbProductPoints.Text);
            bool heated = chkHeat.IsChecked.Value;
            bool dairy = chkDairy.IsChecked.Value;
            bool gluten = chkGluten.IsChecked.Value;
            bool combo = chkCombo.IsChecked.Value;

            //Create object variable to take info and create new object
            Food newLunch = new Lunch(name, price, points, heated, dairy, gluten, combo);

            //Add object to observable collection via method call
            Data.AddProductToCollection(newLunch);
        }

        //Button method to add a breakfast to product observable collection
        private void btnBreakfast_Click(object sender, RoutedEventArgs e)
        {
            //Create variables to take info from various inputs
            string name = tbProductName.Text;
            decimal price = decimal.Parse(tbProductPrice.Text);
            int points = int.Parse(tbProductPoints.Text);
            bool heated = chkHeat.IsChecked.Value;
            bool dairy = chkDairy.IsChecked.Value;
            bool gluten = chkGluten.IsChecked.Value;
            bool combo = chkCombo.IsChecked.Value;

            //Create object variable to take info and create new object
            Food newBreakfast = new Breakfast(name, price, points, heated, dairy, gluten, combo);

            //Add object to observable collection via method call
            Data.AddProductToCollection(newBreakfast);
        }

        //Button method to add a tumbler to product observable collection
        private void btnTumbler_Click(object sender, RoutedEventArgs e)
        {
            //Create variables to take info from various inputs
            string name = tbProductName.Text;
            decimal price = decimal.Parse(tbProductPrice.Text);
            int points = int.Parse(tbProductPoints.Text);
            string color = tbStyle.Text;

            //Create object variable to take info and create new object
            Merchandise newTumbler = new Tumblers(name, price, points, color);

            //Add object to observable collection via method call
            Data.AddProductToCollection(newTumbler);
        }

        //Button method to add a mug to product observable collection
        private void btnMug_Click(object sender, RoutedEventArgs e)
        {
            //Create variables to take info from various inputs
            string name = tbProductName.Text;
            decimal price = decimal.Parse(tbProductPrice.Text);
            int points = int.Parse(tbProductPoints.Text);
            string style = tbStyle.Text;

            //Create object variable to take info and create new object
            Merchandise newMug = new Mugs(name, price, points, style);

            //Add object to observable collection via method call
            Data.AddProductToCollection(newMug);
        }

        //Button method to add a gift card to product observable collection
        private void btnGiftCard_Click(object sender, RoutedEventArgs e)
        {
            //Create variables to take info from various inputs
            string name = tbProductName.Text;
            decimal price = decimal.Parse(tbProductPrice.Text);
            int points = int.Parse(tbProductPoints.Text);
            decimal amount = decimal.Parse(tbProductPrice.Text);

            //Create object variable to take info and create new object
            Product newGiftCard = new GiftCard(name, price, points, amount);

            //Add object to observable collection via method call
            Data.AddProductToCollection(newGiftCard);
        }

        //Method to populate drink size combobox
        void PopulateSizeComboBox()
        {
            //Add various sizes
            cbDrinkSize.Items.Add("Short");
            cbDrinkSize.Items.Add("Tall");
            cbDrinkSize.Items.Add("Grande");
            cbDrinkSize.Items.Add("Venti");
            cbDrinkSize.Items.Add("Trenta");

            //Set index to 0 so a size shows up on load
            cbDrinkSize.SelectedIndex = 0;
        }
        
    }
}
