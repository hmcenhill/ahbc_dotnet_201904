using System;
using System.Collections.Generic;
using System.Text;

namespace Class14
{
    public class Car : IHonk, IBrake
    {
        public void Brake()
        {
            Console.WriteLine("Scurrrchhhhhh");
        }

        public string Honk()
        {
            //Console.WriteLine("Hooooooonk");
            return "Hooooooonk";
        }
    }
}
