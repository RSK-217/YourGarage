using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class ElectricCar : Car
    {

        public ElectricCar(string batteryCapacity, string type,  string color, string occupancy )
        {
            BatteryCapacity = batteryCapacity;
            Type = type;
            Color = color;
            Occupancy = occupancy;
        }

        public string BatteryCapacity { get; set; }

        public void Charging()
        { }
    }
}
