using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class Truck : IVehicle
    {
        public string Type { get; set; }
        public string FuelOrBatteryCapacity { get; set; }

        public string Color { get; set; }

        public string Occupancy { get; set; }
        public string Bedsize { get; set; }

        public Truck() { }

        public void Operating()
        {
            Console.WriteLine($"This is a {Color} {Type} with a fuel capacity of {FuelOrBatteryCapacity}, a bedsize of {Bedsize} and a passenger occupancy of {Occupancy}. ");
        }
    }
}
