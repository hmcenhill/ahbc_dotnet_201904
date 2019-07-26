using System;
using System.Collections.Generic;

namespace Class48.Data
{
    public partial class Movies
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public short? YearReleased { get; set; }
        public int? DirectorId { get; set; }

        public virtual Directors Director { get; set; }
    }
}
