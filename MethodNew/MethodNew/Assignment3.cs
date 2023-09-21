using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodNew.Assignments
{
    internal class Assignment3
    {
        public static string startAssignment3()
        {

            string msg = "Please enter the number :";
            return GetUserInput3(msg);
        }

        public static string GetUserInput3(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            Console.WriteLine("Entered number is here :"+input);
           
            return input;
        }
    }
}
