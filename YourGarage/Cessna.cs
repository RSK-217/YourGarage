using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class Cessna : IVehicle
    {
      
        public string Type { get; set; }
        public string FuelOrBatteryCapacity { get; set; }
        public string Color { get; set; }
        public string Occupancy { get; set; }
        public string Wingspan { get; set; }
        public string Crew { get; set; }

        public Cessna() { }

        public void Operating()
        {
            Console.WriteLine($"This is a {Color} {Type} with a Wingspan of {Wingspan}, a crew of {Crew} and a passenger occupancy of {Occupancy}. ");
        }
    }
}
