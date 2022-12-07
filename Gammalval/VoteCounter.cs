using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammalval
{
    internal class VoteCounter
    {
        // en char skapas vilket ska ha värdet utav retur värdet
        public char Winner;
        // en metod med typen char skapas eftersom returvärdet ska vara en bokstav även är alternativen indata parameterna
        public char WinningVote(int alternativeA, int alternativeB, int alternativeC)
        {
            // if satser skapas för att se vilket alternativ är störst
            if (alternativeA > alternativeB && alternativeA > alternativeB)
            {
                // ifall A vinner får "Winner" värdet 'A'
                return Winner = 'A';
            }
            else if (alternativeB > alternativeA && alternativeB > alternativeC)
            {
                // ifall B vinner får "Winner" värdet 'B'
                return Winner = 'B';
            }
            else if (alternativeC > alternativeA && alternativeC > alternativeB)
            {
                // ifall C vinner får "Winner" värdet 'C'
                return Winner = 'C';
            }
            // annars får det värdet 'X'
            else return Winner = 'X';
        }
    }
}
