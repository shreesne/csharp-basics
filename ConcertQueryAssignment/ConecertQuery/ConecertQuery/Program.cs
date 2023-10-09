
using System;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ConecertQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = "E:\\LEXICON\\Lectures lexicon\\concert_data.json"; // Replace with the actual path to your JSON file

            if (File.Exists(jsonFilePath))
            {
                var concertData = File.ReadAllText(jsonFilePath);
                List<Concert> concerts = JsonConvert.DeserializeObject<List<Concert>>(concertData);
                Console.WriteLine("please enter number to execute query :");
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        DateTime currentDate = DateTime.Now;
                        //Filter and order the concerts by DateTime
                        List<Concert> filteredConcerts = concerts
                      .Where(concert => Convert.ToDateTime(concert.Date) >= currentDate)
                  //  .Where(concert => concert.Date == currentDate)
                       .OrderBy(concert => concert.Date)
                       .ToList();

                        foreach (var concert in filteredConcerts)
                        {
                            Console.WriteLine($"Id: {concert.Id}");
                            Console.WriteLine($"DateTime: {concert.Date}");
                            Console.WriteLine($"Performer: {concert.Performer}");
                            Console.WriteLine($"BeginsAt: {concert.BeginsAt}");
                            Console.WriteLine($"FullCapacitySales: {concert.FullCapacitySales}");
                            Console.WriteLine($"ReducedVenue: {concert.ReducedVenue}");
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        List<Concert> reducedVenueConcerts = concerts
                       .Where(concert => concert.ReducedVenue)
                        .ToList();

                        // Print or use the filtered concerts
                        foreach (var concert in reducedVenueConcerts)
                        {
                            Console.WriteLine($"Id: {concert.Id}");
                            Console.WriteLine($"DateTime: {concert.Date}");
                            Console.WriteLine($"Performer: {concert.Performer}");
                            Console.WriteLine($"BeginsAt: {concert.BeginsAt}");
                            Console.WriteLine($"FullCapacitySales: {concert.FullCapacitySales}");
                            Console.WriteLine($"ReducedVenue: {concert.ReducedVenue}");
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        List<Concert> concertsIn2024 = concerts
                                   .Where(concert => concert.Date.Year == 2024)
                                   .ToList();
                        foreach (var concert in concertsIn2024)
                        {
                            Console.WriteLine($"Id: {concert.Id}");
                            Console.WriteLine($"DateTime: {concert.Date}");
                            Console.WriteLine($"Performer: {concert.Performer}");
                            Console.WriteLine($"BeginsAt: {concert.BeginsAt}");
                            Console.WriteLine($"FullCapacitySales: {concert.FullCapacitySales}");
                            Console.WriteLine($"ReducedVenue: {concert.ReducedVenue}");
                            Console.WriteLine();

                        }
                        
                        break;
                    case 4:
                        var topFiveSales = concerts
                                 .OrderByDescending(concert => concert.FullCapacitySales)
                                 .Take(5);
                        foreach (var concert in topFiveSales)
                        {
                            Console.WriteLine($"Id: {concert.Id}");
                            Console.WriteLine($"DateTime: {concert.Date}");
                            Console.WriteLine($"Performer: {concert.Performer}");
                            Console.WriteLine($"BeginsAt: {concert.BeginsAt}");
                            Console.WriteLine($"FullCapacitySales: {concert.FullCapacitySales}");
                            Console.WriteLine($"ReducedVenue: {concert.ReducedVenue}");
                            Console.WriteLine();


                        }
                        break;
                    case 5:

                        List<Concert> fridayConcerts = concerts
                           .Where(concert => concert.Date.DayOfWeek == DayOfWeek.Friday)
                       .ToList();
                        foreach(var concert in fridayConcerts)
                        {
                            Console.WriteLine($"Id: {concert.Id}");
                            Console.WriteLine($"DateTime: {concert.Date}");
                            Console.WriteLine($"Performer: {concert.Performer}");
                            Console.WriteLine($"BeginsAt: {concert.BeginsAt}");
                            Console.WriteLine($"FullCapacitySales: {concert.FullCapacitySales}");
                            Console.WriteLine($"ReducedVenue: {concert.ReducedVenue}");
                            Console.WriteLine();
                        }
                        break;
                    default: break;


                }
            }
            else
            {
                Console.WriteLine("JSON file not found.");
            }
        }
    }
    
}