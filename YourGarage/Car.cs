using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    internal class Car : Vehicle
    {

        public string Type { get; set; }

        public void Driving()
        {
            Console.WriteLine($"We are driving a {Color} {Type} with {Occupancy} passengers. ");
        }

        public void Braking()
        { }
      



    }
}
