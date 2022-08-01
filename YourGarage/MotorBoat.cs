using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class MotorBoat : IVehicle
    {

        public MotorBoat(){}

        public string Type { get; set; }
        public string FuelOrBatteryCapacity { get; set; }

        public string Color { get; set; }

        public string Occupancy { get; set; }
        public string Engine { get; set; }

        public void Operating()
        {
            Console.WriteLine($"This is a {Color} {Engine} engine {Type} with a fuel capacity of {FuelOrBatteryCapacity} and a passenger occupancy of {Occupancy}. ");
        }

 
    }
}
