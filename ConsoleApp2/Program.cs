using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    

    public class Program
    {
        public static void Main()
        {
            //var x = 125;
            Console.WriteLine("enter the number:");
            int x= Convert.ToInt32(Console.ReadLine());

            Console.Write(isOdd(x) ? "Even value" : "Odd value");
            Console.ReadKey();
        }

        static bool isOdd(int x)
        {
            switch (x % 2)
            {
                case 0:
                    return true;
                case 1:
                    return false;
            }

            return false;
        }
    }
}