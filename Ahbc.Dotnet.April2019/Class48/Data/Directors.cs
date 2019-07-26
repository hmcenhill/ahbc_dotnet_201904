using System;
using System.Collections.Generic;

namespace Class48.Data
{
    public partial class Directors
    {
        public Directors()
        {
            Movies = new HashSet<Movies>();
        }

        public int DirectorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<Movies> Movies { get; set; }
    }
}
