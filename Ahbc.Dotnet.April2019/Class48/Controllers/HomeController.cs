using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Class48.Models;
using Class48.Data;
using System;

namespace Class48.Controllers
{
    public class HomeController : Controller
    {
        private readonly Class48Context _context;

        public HomeController(Class48Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var movies = from m in _context.Movies
            //             where m.YearReleased > 2000
            //             select m;
            
            var movies2 = _context.Movies
                .Where(x => x.YearReleased > 2000)
                .Take(1)
                .Where(x => x.DirectorId == 1);

            foreach (var movie in movies2)
            {
                Console.WriteLine($"{movie.Title}");
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
