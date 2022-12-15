using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Gammalmaklare
{
    class Broker
    {
        public List<RealEstate> RealEstates { get; private set; }

        public Broker()
        {
            RealEstates = new List<RealEstate>()
{
    new RealEstate() {Id=1, Address="Gågatan 22", Rooms=1, Area=57},
    new RealEstate() {Id=4, Address="Strandvägen 1",  Rooms=6, Area=125},
    new RealEstate() {Id=5, Address="Humlestigen 14", Rooms=5, Area=125 },
    new RealEstate() {Id=9, Address="Ljunggatan 12 b", Rooms=1, Area=42 }
};
        }

        public bool AddRealEstate(RealEstate estates)
        {
            RealEstates.Add(estates);
            return true;
        }

        int id = 9;

        // Ger en den nya lägenheten ett nytt ID varenda gång du sparar en lägenhet.
        public int RealEstateID(RealEstate estates)
        {
            // Om AddRealEstate returnerar true så kommer ett nytt ID tillkallas till den nya lägenheten. Startvärdet är nio, och den returnerar det nya id.
            if (AddRealEstate(estates) == true)
            {
                id++;
                estates.Id = id;
            }
            return id;
        }
    }
}
