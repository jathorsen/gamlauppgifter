using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammalegg
{
    internal class Hen
    {
        public string Race { get; set; }

        public double Weight { get; set; }

        Random random = new Random();
        // Lägger metoden här för då kan äggen kommer från hönan.
        // Metoden kollar igenom alla höns, samt slumpar ett tal mellan 0-99. Om random >= 48 får hönan inget ägg då returneras 0, annars returneras 1.
        public int LayEgg()
        {
            if (random.Next(100) >= 48)
            {
                return 0;
            }
            else return 1;
        }

        // Använder konstruktorn Egg för att sätta vikten. Första koden är snarlik den förra, men koden returnar ett nytt Egg, med en random vikt mellan 20 och 81.
        public Egg LayEgg2()
        {
            if (random.Next(100) >= 48)
            {
                return new Egg(random.Next(20, 81));
            }
            else return null;
        }

    }
}
