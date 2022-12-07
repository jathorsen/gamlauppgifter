using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammalval3
{
    internal class Election
    {
        // skapar en List utav typen Party(klassen)
        public List<Party> Parties { get; set; } = new List<Party> { };

        // Denna metod letar igenom Party klassen för att hitta partier.
        public Party FindPartyByShort(string abbreviation)
        {
            // Sedan används loopen för att hitta i Parties listan. Om ett parti som stämmer överens med den lagrade informationen hittas visas den. Annars returnas null;.
            foreach (Party party in Parties)
            {
                if (party.Abbreviation.ToUpper().Equals(abbreviation.ToUpper()))
                {
                    return party;
                }
            }
            return null;
        }
    }
}
