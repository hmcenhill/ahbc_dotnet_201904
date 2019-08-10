using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class54b.Models
{
    public class Planet
    {
        public string Name { get; set; }
        public string Rotation_period { get; set; }
        public string Orbital_period { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        public string Surface_water { get; set; }
        public string Population { get; set; }
        public object[] Residents { get; set; }
        public string[] Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }

}
