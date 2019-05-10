using System;
using System.Collections.Generic;
using System.Text;

namespace Class15.Recapulation
{
    public class Sloth : Animal
    {
        public List<string> ListOfStrings { get; set; }

        public Sloth()
        {
            ListOfStrings = new List<string>();
        }

        public void InAFunction()
        {
            ListOfStrings.Add("Sometime");
        }

        public override string SaySomething()
        {
            return "I'm not saying anything, I'm too tired";
        }
    }
}
