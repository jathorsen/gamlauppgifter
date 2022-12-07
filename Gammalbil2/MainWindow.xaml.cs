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

namespace Gammalbil2
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

        // Skapar nya integers för varenda spelare, vilket används i totalsumman.
        int player1 = 0, player2 = 0, player3 = 0;
        private void btnBet_Click(object sender, RoutedEventArgs e)
        {
            // Skapar en ny int array som tar värdet från GetRandomNumbers() nyskapade array, sen ger till de olika labels.
            int[] numbers = GetRandomNumbers();

            //Kollar ifall checkboxen är ikryssad. Om inte, då ökar spelarens poäng. Om den är icheckad stannar poängen där den är.
            if (chk1.IsChecked == false)
            {
                player1 += numbers[0];
            }
            if (chk2.IsChecked == false)
            {
                player2 += numbers[1];
            }
            if (chk3.IsChecked == false)
            {
                player3 += numbers[2];
            }

            // Skriver ut vad alla labels ska visa.
            lblCode1.Content = numbers[0];
            lblCode2.Content = numbers[1];
            lblCode3.Content = numbers[2];
            lblTotal1.Content = player1;
            lblTotal2.Content = player2;
            lblTotal3.Content = player3;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            // Rensar content på alla labels.
            lblCode1.Content = null;
            lblCode2.Content = null;
            lblCode3.Content = null;
            lblTotal1.Content = null;
            lblTotal2.Content = null;
            lblTotal3.Content = null;
        }

        public int[] GetRandomNumbers()
        {
            Random random = new Random();
            // Gör en ny int array och returnerar arrayen till metoden.
            return new int[] { random.Next(0, 10), random.Next(0, 10), random.Next(0, 10) };
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            //Skapar ett nytt carRegister i koden.
            CarRegister carRegister = new CarRegister();

            // Lägger till en ny bil vid Register knapptrycket.
            Car car = new Car(txtRegPlate.Text, txtMake.Text, txtModel.Text, txtColor.Text);

            // Tillkallar metoden AddCar som kommer lägga till bilen i listan av bilar.
            carRegister.AddCar(car);
        }
    }
}
