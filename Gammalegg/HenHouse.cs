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
        
        public List<Egg> eggs { get; set; } = new List<Egg>();

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

        // Skapar en metod för att lägga till ägg i listan eggs.
        public List<Egg> CollectEggs()
        {
            foreach (Hen hen in Hens)
            {
                // Skapar ett nytt objekt "egg" som tar från listan Egg klassen och kopplar den med LayEgg2 metoden.
                Egg egg = hen.LayEgg2(); 
                // Om egg INTE är null (!= null) så skapas ett ägg i listan eggs.
                if (egg != null)
                {
                    eggs.Add(egg);
                }
            }
            // Returnerar listan eggs.
            return eggs;
        }
    }
}
