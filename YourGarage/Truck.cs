using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class Truck : Car
    {
        public Truck(string bedSize, string type, string fuelcapacity, string color, string occupancy)
        {
            BedSize = bedSize;
            Type = type;
            FuelCapacity = fuelcapacity;
            Color = color;
            Occupancy = occupancy;
            
        }

        public string BedSize { get; set; }

        public void Hauling()
        { }

    }
}
