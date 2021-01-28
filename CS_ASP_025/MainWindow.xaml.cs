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

namespace CS_ASP_025
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // Do the variables 
        string[] items;
        string[] prices;
        int itemNumber = 0;
        int length;
        int num;
        double total;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Complete Labels            
            enterItemsLabel.Content = "Enter items below";

            itemNumberLabel.Content = "1";

            numberOfItemsLabel.Content = 0;

            // Make the variables 
            itemNumber = int.Parse(itemNumberBox.Text);

            length = itemNumber;

            num = length;

            // Finish buttons
            button1.IsEnabled = false;

            button1.Content = "Number of items in list:";

           

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // Finish the arrays and put them to there user input
            items = new string[itemNumber];

            prices = new string[itemNumber];

            // funish up the items as num > 0

            if (num > 0)
            {
                // Add the items and boxes in the textboxes to arrays
                items[length - num] = itemBox.Text;

                prices[length - num] = itemPriceBox.Text;

                // Have to change labels to display new info each time a item is added
                itemListLabel.Content += "\n  " + items[length - num] + " " + "$" + prices[length - num];

                itemNumberLabel.Content = (length - num) + 2;

                numberOfItemsLabel.Content = (length - num) + 1;

                // Need to add a total each time a button is pressed and display
                total += double.Parse(itemPriceBox.Text);

                totalCostLabel.Content = "$" + total;

                // Going to subtract one from the num everytime, till it's at 0
                num--;

                // Once num == 0 is disable, I need to add button and clear labels
                if (num == 0) button2.IsEnabled = false;

                if (num == 0) label2.Content = "";

                if (num == 0) itemNumberLabel.Content = "";
            }

            //Going to clear textBoxes
            itemBox.Text = "";
            itemPriceBox.Text = "";

        }
    }
}