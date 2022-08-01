using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal interface IVehicle
    {

        public string Type { get; set; }
        public string FuelOrBatteryCapacity { get; set; }

        public string Color { get; set; }

        public string Occupancy { get; set; }

        public void Operating()
        { }


    }
}
