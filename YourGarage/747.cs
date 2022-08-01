using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class _747 : IVehicle
    {
        public string Type { get; set; }
        public string FuelOrBatteryCapacity { get; set; }
        public string Color { get; set; }
        public string Occupancy { get; set; }

        public string Wingspan { get; set; }
        public string Crew { get; set; }
        
        public _747() { }
        
        public void Operating() 
        {
            Console.WriteLine($"This is a {Color} {Type} with a Wingspan of {Wingspan}, fuel capacity of {FuelOrBatteryCapacity}, a crew of {Crew} and a passenger occupancy of {Occupancy}. ");
        }
        
       


    }
}
