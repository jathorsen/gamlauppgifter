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

namespace Gammalmaklare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            listBoxRealEstate.ItemsSource = broker.RealEstates;
        }
        Broker broker = new Broker();

        private void btnPrice_Click(object sender, RoutedEventArgs e)
        {
            int cost = Price();

            txtCost.Text = $"{cost} kr/kvm";
        }

        private int Price()
        {
            int endPrice = int.Parse(txtPrice.Text);
            int squareKM = 57;

            if (endPrice.ToString().Length <= 4)
            {
                endPrice = Convert.ToInt32(endPrice) * 1000;
            }

            int cost = endPrice / squareKM;
            return cost;

        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int test = FixedPrice();
            txtRemakeDone.Text = $"{test:C0} kr/kvm";
        }

        private int FixedPrice()
        {
            int fixedEndPrice = int.Parse(txtRemake.Text);
            int squareKM = 57;

            if (fixedEndPrice.ToString().Length <= 4)
            {
                fixedEndPrice = Convert.ToInt32(fixedEndPrice) * 1000;
            }

            txtRemake.Text = fixedEndPrice.ToString("C0");

            int fixedCost = fixedEndPrice / squareKM;
            return fixedCost;
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            listBoxRealEstate.ItemsSource = null;
            listBoxRealEstate.ItemsSource = Estates();
        }

        private List<RealEstate> Estates()
        {
            int minimum = int.Parse(txtMin.Text);
            int maximum = int.Parse(txtMax.Text);

            List<RealEstate> estate = new List<RealEstate>();

            foreach (RealEstate rooms in broker.RealEstates)
            {
                if (minimum == rooms.Rooms)
                {
                    estate.Add(rooms);
                }
                if (maximum == rooms.Rooms)
                {
                    estate.Add(rooms);
                }
            }
            return estate;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (broker.AddRealEstate() == true)
            {
                listBoxRealEstate.ItemsSource = null;
                listBoxRealEstate.ItemsSource = broker.RealEstates;
            }
        }
    }
}
