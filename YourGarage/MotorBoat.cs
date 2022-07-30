using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class MotorBoat : Watercraft
    {

        public MotorBoat(string engine, string type, string fuelcapacity, string color, string occupancy)
        {
            Engine = engine;
            Type = type;
            FuelCapacity = fuelcapacity;
            Color = color;
            Occupancy = occupancy;
        }

        public string Engine { get; set; }

        public void StartingMotor()
        { }
    }
}
