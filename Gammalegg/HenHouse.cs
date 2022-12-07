using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammalegg
{
    internal class HenHouse
    {
        public List<Hen> Hens { get; set; } = new List<Hen>();

        public int Stable { get; set; }

        // Lägger till hönor i Hens via en forloop.
        public HenHouse(int addHens)
        {
            for(int i = 0; i < addHens; i++)
            {
                Hens.Add(new Hen());
            }
        }

        // Lägger koden här för att jag har tillgång till listan av alla höns.
        // Använder Hen hen för att kunna nå LayEgg() metoden i Hen.cs. Efter det så läggs ett ägg in i sum om hönor får ägg, vilket returneras i slutet.
        public int CountEggs()
        {
            int sum = 0;
            foreach (Hen hen in Hens)
            {
                sum += hen.LayEgg();
            }
            return sum;
        }
    }
}
