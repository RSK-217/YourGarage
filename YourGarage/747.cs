using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class _747 : Aircraft
    {
        public _747(string crew, string type, string wingspan, string fuelcapacity, string color, string occupancy)
        {
            Crew = crew;
            Type = type;
            Wingspan = wingspan;
            FuelCapacity = fuelcapacity;
            Color = color;
            Occupancy = occupancy;
        }

        public string Crew { get; set; }

        public void Boarding()
        { }
    }
}
