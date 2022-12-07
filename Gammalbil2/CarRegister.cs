using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammalbil2
{
    internal class CarRegister
    {
        public List<Car> Cars { get; set; } = new List<Car>();

        public bool AddCar(Car car)
        {
            // Här kollar koden igenom ifall HasCorrectFormat returnar true, isåfall läggs en ny bil in i listan av Car. Om inte returneras false.
            if (HasCorrectFormat(car.LicensePlate))
            {
                Cars.Add(car);
                return true;
            }
            else return false;
        }

        private bool HasCorrectFormat(string p)
        {
            // Denna kod använder sig av en string = plate som kopplas ihop med regplåten.

            // Därefter så kollar koden ifall plate är mer än sju tecken.
            string plate = p.ToUpper();
            if (!plate(p) < 7)
            {
                return false;
            }
            // Här kollar koden ifall den fjärde figuren är ett mellanslag med IsWhiteSpace(plate[3])). Den letar efter det fjärde [3] värdet av chars i stringen plate.
            if (!char.IsWhiteSpace(plate[3]))
            {
                return false;
            }
            // Här kollar koden ifall någon de första tre chars ens är bokstäver, eller ifall det innehåller O,I och Q. Om det ej är bokstäver eller det innehåller O,I,Q så returneras false.
            for (int i = 0; i< 3; i++)
            {
                if (!char.IsLetter(plate[i]))
                {
                    return false;
                }
                else if (plate[i].Equals('O') || plate[i].Equals('I') || plate[i].Equals('Q'))
                {
                    return false;
                }
            }
            // Sista så kollar for-loopen ifall regnummret innehåller siffror eller ej. Om inte returneras false.
            for (int i = 4; i< 7; i++)
            {
                if (!char.IsDigit(plate[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
