using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp5
{ class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("area of rectangle:");
            Console.WriteLine("enter length of rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the width of rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = calculateRectangleArea(length, width);
            // Console.WriteLine("area of rectangle is:", area);
            Console.WriteLine($"The area of the rectangle is: {area}");

            Console.ReadKey();
        }

            static double calculateRectangleArea(double length, double width)
            {
                return length * width;
            }
        
}
}
