using FirstRazorApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstRazorApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult<string> Test(string name)
        {
            // Get data from database

            var greeter = $"Hello World and {name}";


            // Ok() returns JSON
            return Ok(greeter);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
