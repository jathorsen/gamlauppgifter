using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammalval3
{
    internal class Party
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public double Percentage { get; set; }
        public int NumberOfVotes { get; set; }


        public Party(string name, string abbreviation)
        {
            Name = name;
            Abbreviation = abbreviation;

        }
        public Party() { }

        // SKAPA EN OVERRIDE TO STRING METOD FÖR ATT FÅ NAMN PÅ LISTA
        public override string ToString()
        {
            return Name;
        }
    }
}
