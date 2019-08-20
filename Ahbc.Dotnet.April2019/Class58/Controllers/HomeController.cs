using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Class58.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Class58.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Configuration _config;

        public HomeController(IOptions<Configuration> config, ILogger<HomeController> logger)
        {
            _logger = logger;
            _config = config.Value;
        }

        public IActionResult Index()
        {
            _logger.LogDebug("It's nice when you are in on the secret.");
            _logger.LogTrace("Can someone let me in on the secret? Puh puh lease... seriously.");
            ViewData["WelcomeText"] = _config.WelcomeText;
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
