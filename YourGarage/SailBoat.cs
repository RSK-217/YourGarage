using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class SailBoat : IVehicle
    {
        public SailBoat(){ }
        

        public string Type { get; set; }
        public string FuelOrBatteryCapacity { get; set; }

        public string Color { get; set; }

        public string Occupancy { get; set; }
        public string Mastsize { get; set; }

        public void Operating()
        {
            Console.WriteLine($"This is a {Color} {Type} with a mast size of {Mastsize} feet and a passenger occupancy of {Occupancy}. ");
        }
    }
}
