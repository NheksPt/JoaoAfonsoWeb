using JoaoAfonsoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JoaoAfonsoWeb.Controllers
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

        public IActionResult Modelacao()
        {
            return View();
        }

        public IActionResult Animacao()
        {
            return View();
        }

        public IActionResult Escultura()
        {
            return View();
        }

        public IActionResult Contactos()
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