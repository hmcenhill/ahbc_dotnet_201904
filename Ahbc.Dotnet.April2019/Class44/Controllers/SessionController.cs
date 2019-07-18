using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class44.Controllers
{
    public class SessionController : Controller
    {
        private readonly ISession _session;

        public SessionController(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
        }

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

        public IActionResult TempDataExample()
        {
            TempData["Ticks"] = DateTime.Now.Ticks;
            return RedirectToAction("TempDataGood");
        }

        public IActionResult TempDataGood()
        {
            return View();
        }

        public IActionResult SessionExample()
        {
            _session.SetString("Ticks", DateTime.Now.Ticks.ToString());
            return RedirectToAction("SessionGood");
        }

        public IActionResult SessionGood()
        {
            ViewData["Ticks"] = _session.GetString("Ticks");
            return View();
        }
    }
}