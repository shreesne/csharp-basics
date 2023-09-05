using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

           
                // Data source
                string[] names = { "Bill", "Steve", "James", "Mohan" };

                // LINQ Query 
                var myLinqQuery = from name in names
                                  where name.Contains('a')
                                  select name;

                // Query execution
                foreach (var name in myLinqQuery)
                     Console.Write(name + " ");
                   Console.ReadKey();
            }
        }
    }
    