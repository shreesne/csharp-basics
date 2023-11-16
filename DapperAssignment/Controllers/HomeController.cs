using DapperAssignment.DataAccess;
using DapperAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DapperAssignment.Controllers
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
            var cities = new CityQuery().CitiesStartWithBor();
            return View(cities);
        }

        public IActionResult Basic()
        {
             var citiesInRange = new CityQuery().GetAllCities(95000, 100000);
             return View(citiesInRange);
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