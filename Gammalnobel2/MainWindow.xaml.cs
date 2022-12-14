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

namespace Gammalnobel2
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

        Dinner dinner = new Dinner();
        private void btnGetSeats_Click(object sender, RoutedEventArgs e)
        {
            dinner.GetSeatNumber(1203);
            dinner.GetSeatNumber(1001);
            dinner.GetSeatNumber(1203);
        }

        private void btnWinners_Click(object sender, RoutedEventArgs e)
        {
            // Kallar på GetWinners för att få fram vinnarna i loopen.
            dinner.GetWinners();
        }

        private void btnHiddenGuest_Click(object sender, RoutedEventArgs e)
        {
            // Här deklarerar jag en ny variable med samma namn, som tar värdet från metoden FindSecretGuest.
            int secretGuest = dinner.FindSecretGuest();

            // Om person.Id matchar vad secretGuest är så returneras en string med personens namn och efternamn. Koden fungerar.
            foreach (Person person in dinner.Guests)
            {
                if (person.Id == secretGuest)
                {
                    MessageBox.Show($"Den hemliga gästen är {person.Firstname} {person.Lastname}");
                }
            }
        }

        // Hämtar dinner.Guests listan och använder det som listBoxGuests itemsource!
        private void btnGetGuests_Click(object sender, RoutedEventArgs e)
        {
            listBoxGuests.ItemsSource = dinner.Guests;
        }

        // Nedan är bonusuppgiften!

        private void btnBonus_Click(object sender, RoutedEventArgs e)
        {
            //GetOddCategory([1,1,2]);
            //GetOddCategory();
            //GetOddCategory();
        }

        //private int GetOddCategory(/*int[] oddNumbers*/)
        //{
        //    int number = 0;
        //    int[] numbers = new int[] { 1, 1, 2 };

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers)
        //        {
        //            number = numbers[i];
        //        }
        //    }
        //    return number;
        //}
    }
}
