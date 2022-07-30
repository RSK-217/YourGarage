using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class Watercraft : Vehicle
    {

        public string Type { get; set; }

        public void Driving()
        {
            Console.WriteLine($"We are on the river in our {Type} with {Occupancy} people aboard.");
        }
    }
}
