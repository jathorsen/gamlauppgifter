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

namespace Gammalnobel
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            double C = 12.01, H = 1.01, N = 14.01, O = 16;
            double totalWeight = (C*3) + (H*5) + (N*3) + (O*9);

            // Använder mig av (int) för att "tvinga" totalWeight att bli en integer och inte en double.
            MessageBox.Show($"Molekylärvikten för nitroglycerin är: {(int)totalWeight}");
            MessageBox.Show($"Det korrekta värdet är: {totalWeight}");
        }

        // GÖR SEN, EVENTUELLT MED HJÄLP!
        private void btnBoom_Click(object sender, RoutedEventArgs e)
        {
            int strength = 0;
            strength = int.Parse(txtBoom.Text);

            string boom = "B";

            // Om strength är mer än 1
            if (strength > 0)
            {
                // Så kommer for-loopen starta och gå igenom värdet av strength, sedan läggs lika många "o" till i strängen boom för varenda värde i strength.
                for (int i = 0; i < strength; i++)
                {
                    boom += "o";
                }
                boom += "m!";
            }
            else
            {
                txtExplosion.Text = "Pfft!";
            }
            txtExplosion.Text = boom;
        }

        // Få hjälp av någon här sen!

        public static double GetAtomicWeight(char atom)
        {
            return atom switch
            {
                'C' => 12.0107,
                'H' => 1.00794,
                'N' => 14.0067,
                'O' => 15.9994,
                'S' => 32.065,
                _ => 0,
            };
        }

        private void btnMolecules_Click(object sender, RoutedEventArgs e)
        {
            CalculateMolecularWeight("C3H5N3O9");
            CalculateMolecularWeight("H2O");
        }

        private double CalculateMolecularWeight(string molecule)
        {
            double weight = 0, value = 0, count = 0;
            
            // Foreach loopen letar efter chars i stringen "molecule".
            foreach (char atom in molecule)
            {
                // Om det är en bokstav blir "value" samma som bokstaven den motsvarar i GetAtomicWeight, exempelvis om det är C blir value C.
                if (Char.IsLetter(atom))
                {
                    value = GetAtomicWeight(atom);
                }
                // count = Char.GetNumericValue räknar vad en viss bokstav är värd, exempelvis C = 12.0107.
                // weight = count * value. Likt första upppgiften (se över, btnOk_Click). Sedan resetas count till 0.
                else
                {
                    count = Char.GetNumericValue(atom);
                    weight += count * value;
                    count = 0;
                }
            }
            // När count då är 0 så kommer weight bli lika mycket som value.
            if (count == 0)
            {
                weight += value;
            }
            return weight;
        }
    }
}
