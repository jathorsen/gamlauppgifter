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

namespace Gammalegg
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

        private void btnEggs_Click(object sender, RoutedEventArgs e)
        {
            int eggs = int.Parse(txtEggs.Text);

            double eggValue = 3.56;
            int cartons = eggs / 12;

            txtNumberofEggs.Text = $"Du ska leverera {cartons} st kartonger till ett pris av {cartons * 12 * 3.56} kronor";
        }

        private void btnIsBroken_Click(object sender, RoutedEventArgs e)
        {
            int eggBroken = 0;
            int eggNotBroken = 0;
            bool[] isBroken = new bool[] { true, true, true, false, true, false,
            false, true, true, false, true, true, false, false, true, true, false,
            true, false, false, true, false, true, true, true, true, false, false,
            false, false, false, false, false, true, false, false, true, false,
            false, true, false, true, true, true, false, true, false, true, false,
            true, true, true, false, true, false, false, false, false, false, false,
            false, false, true, false, true, false, false, true, false, false, false,
            true, true, false, false, true, true, false, true, true, false, false,
            true, true, true, false, false, false, false, true };

            // broken är alla true/false statements i isBroken, och om det stämmer lägger det till i eggBroken integern.
            foreach (bool broken in isBroken)
            {
                if (broken == true)
                {
                    eggBroken++;
                }
                else eggNotBroken++;
            }

            MessageBox.Show($"Av {isBroken.Length} ägg är det {eggBroken} som är trasiga och {eggNotBroken} som är hela");

            PinkCodes();
        }

        private int PinkCodes()
        {
            int containsCodes = 0;
            List<string> pinkCodes = new List<string>() {"1SE123-2", "0SE675-6",
            "2SE122-4", "0SE234-1", "0SE234-5", "2SE564-4", "0SE234-2", "1SE564-6",
            "2SE144-5", "0SE675-1", "1SE144-1", "2SE144-3", "1SE123-4", "2SE122-2",
            "1SE122-6", "0SE234-2", "2SE123-3", "1SE234-3", "1SE123-6", "1SE123-4",
            "0SE122-2", "1SE144-3", "0SE234-4", "0SE564-1", "0SE234-4", "2SE144-3",
            "2SE122-3", "1SE234-3", "1SE123-4", "1SE564-5", "1SE123-1", "2SE122-6",
            "0SE123-6", "1SE564-6", "1SE234-5", "1SE564-6", "2SE234-2", "1SE234-3",
            "0SE234-3", "2SE122-5", "2SE234-2", "2SE144-2", "2SE564-5", "1SE144-5",
            "1SE675-4", "1SE123-6", "2SE564-6", "1SE122-6", "1SE122-5", "2SE122-2",
            "1SE234-2", "0SE675-5", "2SE122-4", "1SE234-6", "0SE564-4", "1SE564-6",
            "2SE675-3", "1SE144-4", "2SE564-5", "0SE564-1", "1SE564-4", "1SE123-4",
            "1SE564-6", "2SE122-2", "1SE564-5", "2SE234-4", "1SE564-4", "2SE122-1",
            "2SE123-3", "2SE564-2", "2SE234-4", "1SE144-1", "1SE675-1", "0SE144-1",
            "2SE123-6", "0SE123-5", "2SE144-6", "0SE144-6", "1SE122-4", "1SE675-6",
            "0SE122-6", "2SE144-2", "2SE122-3", "1SE234-5", "1SE564-2", "1SE144-5",
            "0SE144-1", "1SE144-3", "1SE122-4", "1SE123-1"};

            // Letar efter "123" i pinkCodes listan. codes.Contains("123)) letar eller alla strings som innehavar 123 i sig. returnar containsCodes för antalet.
            foreach (string codes in pinkCodes)
            {
                if (codes.Contains("123"))
                {
                    containsCodes++;
                }
            }
            return containsCodes;
        }
        private void btnAddHens_Click(object sender, RoutedEventArgs e)
        {
            HenHouse henHouse = new HenHouse(250);
            henHouse.CountEggs();
        }
    }
}
