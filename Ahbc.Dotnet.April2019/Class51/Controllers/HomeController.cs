using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Class51.Data;
using Microsoft.AspNetCore.Mvc;
using Class51.Models;
using Microsoft.AspNetCore.Authorization;

namespace Class51.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public IActionResult Secret()
        {
            var user = User;
            var isInRole = user.IsInRole("Administrator");
            var userRoles = _context.UserRoles.ToList();
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult SuperSecret()
        {
            var user = User;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
