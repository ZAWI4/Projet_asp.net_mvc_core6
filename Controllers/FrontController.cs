using Microsoft.AspNetCore.Mvc;
using Projet_asp.Models;
using System.Diagnostics;

namespace Projet_asp.Controllers
{
    public class FrontController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public FrontController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Chef()
        {
            return View();
        }
        public IActionResult Rservation()
        {
            return View();
        }
        public IActionResult Gallerie()
        {
            return View();
        }
        public IActionResult Contact()
        {
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
