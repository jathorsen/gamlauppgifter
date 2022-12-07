using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammalbil2
{
    internal class Car
    {
        public string LicensePlate { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        // Skapar vad som behövs för att skapa en bil i en konstruktor (ctor).
        public Car(string licensePlate, string make, string model, string color)
        {
            LicensePlate = licensePlate;
            Make = make;
            Model = model;
            Color = color;
        }
    }
}
