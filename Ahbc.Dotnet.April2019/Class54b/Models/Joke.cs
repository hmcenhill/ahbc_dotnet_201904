using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class54b.Models
{

    public class Joke
    {
        public string Type { get; set; }
        public Value Value { get; set; }
    }

    public class Value
    {
        public int Id { get; set; }
        public string Joke { get; set; }
        public string[] Categories { get; set; }
    }

}
