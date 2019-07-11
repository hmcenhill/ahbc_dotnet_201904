using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SomethingCool.Models;

namespace SomethingCool.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy(int? id)
        {
            var model = new PrivacyViewModel
            {
                PolicyVerbiage = "Some super sweet verbiage!",
                AsOf = DateTime.UtcNow
            };

            //ViewData["Display"] = true;
            //ViewData["Title"] = "Privacy";

            ViewBag.Display = true;
            ViewBag.Title = "Privacy";

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
