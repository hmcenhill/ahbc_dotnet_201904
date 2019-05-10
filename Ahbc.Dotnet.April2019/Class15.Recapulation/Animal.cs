using System;
using System.Collections.Generic;
using System.Text;

namespace Class15.Recapulation
{
    public abstract class Animal
    {
        public void DoSomething()
        {
            Console.WriteLine("All child classes will inherit this");
        }

        public abstract string SaySomething();
    }
}
