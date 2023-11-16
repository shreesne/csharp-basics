using DapperAssignment.DataAccess;
using DapperAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperAssignment.Controllers
{
    public class CityController : Controller
    {
        public ActionResult optional1()
        {
            var limitPosts = new CityQuery().GetLimitNoPosts();
            return View(limitPosts);
        }

        public ActionResult optional2()
        {
            var cities = new CityQuery().CitiesByCountryCode("NLD");
            return View(cities);
        }

        public ActionResult optional3()
        {
            var countriesInRange = new CityQuery().GetEuropeanCountriesByLifeExpectancy();
            return View(countriesInRange);
        }

        public ActionResult optional4()
        {
            var cities = new CityQuery().ReadAllCities();
            return View(cities);
        }
        public ActionResult optional5()
        {
            var cities = new CityQuery().CitiesByContinentWithAge("Asia",75);
            return View(cities);
        }
    }
}
