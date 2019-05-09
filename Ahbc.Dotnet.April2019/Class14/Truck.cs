using System;
using System.Collections.Generic;
using System.Text;

namespace Class14
{
    public class Truck : IVehicle
    {
        public void Drive(string speed)
        {
            Console.WriteLine($"Drive {speed} miles per hour");
        }

        public void Drive()
        {
            Drive("45");
        }

        public void Brake()
        {
            Console.WriteLine("Truck Stop");
        }

        public void EngageFourWheel()
        {
            // Do some four wheel drive stuff
        }

        public string Honk()
        {
            return "Truck hoooonk";
        }
    }
}
