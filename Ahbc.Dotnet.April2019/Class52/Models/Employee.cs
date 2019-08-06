using System.Collections.Generic;

namespace Class52.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public EmployeeName Name { get; set; }
        public string Nickname { get; set; }
        public ICollection<Coworker> Coworkers { get; set; }
    }
}
