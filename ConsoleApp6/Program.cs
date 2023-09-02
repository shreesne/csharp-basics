using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            
            
            int[] array1 = { 0, 1, 13, 25, 55, 96 };

            foreach (int value in array1)
            {

                Console.WriteLine(value);
               
            }
            Console.WriteLine();
            Array.Reverse(array1);

            foreach (int value in array1)
            {
                Console.WriteLine(value);
                Console.ReadKey();
            }
        }
     }
}