using System;
using System.Collections.Generic;
using System.Text;

namespace Class9
{
    public class Animal
    {
        public Animal(string name)
        {
            _name = name;
        }

        private string _name;

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
