using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SomethingCool.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [MaxLength(2, ErrorMessage = "Name too long dude")]
        public string FirstName { get; set; }
        
        [MaxLength(2)]
        public string LastName { get; set; }
        
        public int Age { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
    }
}
