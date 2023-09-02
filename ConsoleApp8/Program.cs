using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
   

class Program
        {
            static void Main()
            {
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                
            }
            Console.WriteLine();
            Console.WriteLine();

            // Define a Predicate that checks if a number is even
            Predicate<int> isEven = x => x % 2 == 0;

                // Use FindAll to filter the list based on the Predicate
                List<int> evenNumbers = numbers.FindAll(isEven);

                // Display the even numbers
                foreach (int number in evenNumbers)
                {
                    Console.WriteLine(number);
                }
                Console.ReadKey();
            }
        }

    }


