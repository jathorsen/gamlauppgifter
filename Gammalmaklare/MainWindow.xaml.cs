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

            // Om endPrice är 4 bokstäver kommer det multipliceras så det hamnar i miljonen.
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

            // Om endPrice är 4 bokstäver kommer det multipliceras så det hamnar i miljonen, bara lite snyggare med "C0" lite senare i koden.
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

            // Skapar en ny lista som kommer returnera en lista av "estate".
            List<RealEstate> estate = new List<RealEstate>();

            // Kollar igenom RealEstates listan för att se vilka lägenheter som har minimum likaså maximum rum. Om minimum/maximum stämmer överens med någon
            // lägenhet i RealEstates listan kommer de läggas till i den nya "estate" listan, vilket tillkalas i metoden btnFilter_Click.
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
            // Skapar en ny estate vid knapptryck.
            RealEstate estate = new RealEstate();

            // Ganska standard, textboxarna = estate.x.
            estate.Address = txtAddress.Text;
            estate.Area = int.Parse(txtArea.Text);
            estate.Rooms = int.Parse(txtRooms.Text);

            // Om AddRealEstate är true så kommer ett nytt ID tilldelas till den nya estaten, likaväl lägger till i listBoxen.
            if (broker.AddRealEstate(estate) == true)
            {
                estate.Id = broker.RealEstateID(estate);
                listBoxRealEstate.ItemsSource = null;
                listBoxRealEstate.ItemsSource = broker.RealEstates;
            }
        }
    }
}
