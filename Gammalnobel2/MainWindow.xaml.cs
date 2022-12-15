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
            int[] oddNumber1 = { 1, 1, 2 };
            GetOddCategory(oddNumber1);

            int[] oddNumber2 = {0,1,0,1,0};
            GetOddCategory(oddNumber2);

            int[] oddNumber3 = { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 };
            GetOddCategory(oddNumber3);
        }

        private int GetOddCategory(int[] oddNumbers)
        {
            // Här loopar jag två gånger. I första loopen tar jag fram numbers i oddNumbers.
            foreach (int numbers in oddNumbers)
            {
                int number = 0;
                // I denna loop tar jag fram numbers2 oddNumbers, sedan jämförs numbers och numbers2.
                foreach (int numbers2 in oddNumbers)
                {
                    if (numbers == numbers2) // Jämför. Om de är lika plussas number på, och loopen fortsätter.
                    {
                        number++;
                    }
                }
                // När loopen är klar så kollar det vilket tal som är udda.
                if (number %2 != 0) //Här kollar jag ifall talet är ett udda antal, med hjälp av modulus. Om number modulus 2 INTE blir noll, returneras numbers.
                {
                    return numbers;
                }
            }
            return 0;
        }
    }
}
