using Microsoft.EntityFrameworkCore;
using SomethingCool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomethingCool.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {  }

        public DbSet<Employee> Employees { get; set; }
    }
}
