using ASM0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASM0.Controllers
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
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Abc()
        {

            List<string> list = new List<string>();
            list.Add("Hieu1");
            list.Add("Hieu2");
            list.Add("Hieu3");
            ViewData["list"] = list;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}