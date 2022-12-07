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

namespace Gammalbil
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int carWeight = int.Parse(txtWeight.Text);

            // Ganska uppenbart vad jag gjort här.
            lblB.Content = 3500 - carWeight;
            lblExtendedB.Content = 4250 - carWeight;
        }

        private void btnControl_Click(object sender, RoutedEventArgs e)
        {
            string correctLength = txtPlatenumber.Text;
            if (HasCorrectLength(correctLength) == false)
            {
                MessageBox.Show("Skylten har ett felaktigt antal tecken");
            }
            
        }

        // Kollar om correctLength är 7, om inte returneras false.
        public bool HasCorrectLength(string correctLength)
        {
            if (correctLength.Length == 7)
            {
                return true;
            }
            else return false;
        }

        int currentNumber = 0;
        private void btnPlatespotting_Click(object sender, RoutedEventArgs e)
        {
            Random n = new Random();
            int numbers = n.Next(1, 10);
            lblRandomNumber.Content = $"{GetRandomLetters()} {numbers.ToString("D3")}";

            // Använder currentNumber som en enkel räknare. Om numbers innehåller currentNumber + ett till value så blir currentNumber till numbers, sen fortsätter det här.
            if (numbers == currentNumber + 1)
            {
                currentNumber = numbers;
                lblSavedPlate.Content = $"{GetRandomLetters()} {numbers.ToString("D3")}";
            }
        }

        private static string GetRandomLetters()
        {
            Random r = new Random();
            string okLetters = "ABCDEFGHJKLMNPRSTUWXYX";
            string letters = "";
            for (int i = 0; i < 3; i++)
            {
                int index = r.Next(okLetters.Length);
                letters += okLetters[index].ToString();
            }
            return letters;
        }
    }
}
