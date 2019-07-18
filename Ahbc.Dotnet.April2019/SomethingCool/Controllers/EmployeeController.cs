using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SomethingCool.Data;
using SomethingCool.Models;

namespace SomethingCool.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDataRepository _repository;

        public EmployeeController(IDataRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var employee = _repository.Get(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(int id, Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }

            _repository.Save(id, employee);

            return RedirectToAction("Index", "Home");
        }
    }
}