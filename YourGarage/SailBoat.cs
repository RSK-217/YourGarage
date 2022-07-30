using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class SailBoat : Watercraft
    {
        public SailBoat(string mastsize, string type, string color, string occupancy)
        {
            Mastsize = mastsize;
            Type = type;
            Color = color;
            Occupancy = occupancy;
        }

        public string Mastsize { get; set; }

        public void Sailing()
        { }
    }
}
