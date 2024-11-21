using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PragueParking2
{
    public class Car : Vehicle
    {
        public Car(string regNumber) : base(regNumber)
        {
            Size = 4;  // TODO: skall hämtas från konfigurationsfil
            PricePerHour = 20; // TODO: också från konfigfil
        }
    }
}