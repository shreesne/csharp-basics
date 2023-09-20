using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMethod
{
    internal class Assignment3
    {
        public static string startAssignment3()
        {
            string message1 = "please enter a number";
            return GetUserInput(message1);

        }
        public static string GetUserInput(string message)
        {
            Console.Write("Please enter a number :");
            var result = Console.ReadLine();
            Console.WriteLine("Entered number is here:" + result);
            return result;
        }

            
        
    }
}
