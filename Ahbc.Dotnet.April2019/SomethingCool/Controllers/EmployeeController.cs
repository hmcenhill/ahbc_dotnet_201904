using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SomethingCool.Models;

namespace SomethingCool.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            // Call database here
            // Instead lets create an employee manually
            var employee = new Employee
            {
                Id = 1,
                FirstName = "Jason",
                LastName = "Robert",
                Age = 35,
                Email = "jason@grandcircus.co"
            };

            return View(employee);
        }
    }
}