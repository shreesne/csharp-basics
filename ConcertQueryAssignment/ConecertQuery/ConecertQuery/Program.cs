
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
                        DateTime startDate = new DateTime(2024, 01, 01, 0, 0, 0);
                        DateTime endDate = new DateTime(2024, 12, 31, 23, 59, 59);
                        List<Concert> concertsIn2024= concerts.FindAll(concert => concert.Date >= startDate && concert.Date <= endDate);
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
                        concerts.Sort((c1, c2) => c2.FullCapacitySales.CompareTo(c1.FullCapacitySales));
                        Console.WriteLine("Top 5 Concerts by Full Capacity Sales:");
                        for (int i = 0; i < Math.Min(5, concerts.Count); i++)
                        {
                            Console.WriteLine($"Id: {concerts[i].Id}");
                            Console.WriteLine($"DateTime: {concerts[i].Date}");
                            Console.WriteLine($"Performer: {concerts[i].Performer}");
                            Console.WriteLine($"BeginsAt: {concerts[i].BeginsAt}");
                            Console.WriteLine($"FullCapacitySales: {concerts[i].FullCapacitySales}");
                            Console.WriteLine($"ReducedVenue: {concerts[i].ReducedVenue}");
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