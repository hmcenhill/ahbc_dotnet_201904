using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Class44.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewDataExample()
        {
            ViewData["Ticks"] = DateTime.Now.Ticks;
            return RedirectToAction("ViewDataBad");
        }

        public IActionResult ViewDataBad()
        {
            return View();
        }

        public IActionResult ViewBagExample()
        {
            ViewBag.Ticks = DateTime.Now.Ticks;
            return View();
        }
    }
}