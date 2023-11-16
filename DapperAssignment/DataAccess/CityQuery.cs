using Dapper;
using DapperAssignment.Models;
using MySqlConnector;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace DapperAssignment.DataAccess
{
    public class CityQuery
    {
        public CityQuery()
        {

        }
        string connectionString = "server=localhost;database=world;AllowUserVariables=True;password=12345;user=root";
        List<City> cities = new List<City>();
        List<Country> countries = new List<Country>();


        public List<City> CitiesStartWithBor()
        {
            string sql = "SELECT * FROM city WHERE name LIKE 'bor%';";
            using (var connection = new MySqlConnection(connectionString))
            {
                cities = connection.Query<City>(sql).ToList();

            }
            return cities;
        }

            public List<City> GetAllCities(int minPopulation, int maxPopulation)
        {

            string sql = "SELECT * FROM City WHERE Population >= @minPopulation AND Population <= @maxPopulation";
            using (var connection = new MySqlConnection(connectionString))
            {
                cities = connection.Query<City>(sql, new { minPopulation, maxPopulation }).ToList();
            }
            return cities;
        }

        public List<Country> GetEuropeanCountriesByLifeExpectancy()
        {
            string sql = "SELECT Name,Continent,LifeExpectancy FROM Country WHERE Continent = 'Europe' ORDER BY LifeExpectancy DESC";
            using (var connection = new MySqlConnection(connectionString))
            {
                countries = connection.Query<Country>(sql).ToList();
            }
            return countries;
        }
        public List<City> GetLimitNoPosts()
        {
            List<City> cities = new List<City>();
            string sql = "SELECT * FROM CITY  LIMIT 10";
            using (var connection = new MySqlConnection(connectionString))
            {
                cities = connection.Query<City>(sql).ToList();
            }
            return cities;
        }
        public List<City> CitiesByCountryCode(string code)
        {
            List<City> cities = new List<City>();

            string sql = "SELECT * FROM city WHERE countrycode = @countrycode;";


            using (var connection = new MySqlConnection(connectionString))
            {
                cities = connection.Query<City>(sql, new { countrycode = code }).ToList();
            }

            return cities;
        }
        public List<City> ReadAllCities()
        {
            string sql = "SELECT  city.id,city.name, city.countrycode FROM country LEFT JOIN city ON country.code = city.countrycode ORDER BY country.code ASC, city.id ASC;";

            using (var connection = new MySqlConnection(connectionString))
            {
                cities = connection.Query<City>(sql).ToList();
            }
            return cities;
        }
        public List<City> CitiesByContinentWithAge(string continent, double minLifeExpectancy)
        {
            string sql = "SELECT city.name,city.countrycode FROM city  JOIN country ON city.countrycode = country.code  WHERE country.continent =@continent  AND country.lifeexpectancy > @lifeexpectancy ORDER BY country.code ASC, city.id ASC; ";
            using (var connection = new MySqlConnection(connectionString))
            {
               cities = connection.Query<City>( sql,new {continent=continent,LifeExpectancy=minLifeExpectancy}).ToList();
            }
            return cities;
        }
    }
}
