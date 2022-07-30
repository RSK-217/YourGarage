using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class Aircraft : Vehicle
    {
        public string Type { get; set; }
        public string Wingspan { get; set; }

        public void Flying()
        {
            Console.WriteLine($"The {Type} aircraft is in the air with {Occupancy} people aboard.");
        }

        public void Landing()
        { }

    }
}
