using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class Cessna : Aircraft
    {
        public Cessna (string engineType,string type, string wingspan, string fuelcapacity, string color, string occupancy)
        {
            EngineType = engineType;
            Type = type;
            Wingspan = wingspan;
            FuelCapacity = fuelcapacity;
            Color = color;  
            Occupancy = occupancy;
        }

        public string EngineType { get; set; }

        public void StartingEngines()
        { }
    }
}
