using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Class53b.Models;

namespace Class53b.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://api.icndb.com");

                var response = await client.GetAsync("jokes/random");
                var joke = await response.Content.ReadAsAsync<Joke>();

                return View(joke);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
