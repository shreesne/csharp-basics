using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMethod
{
    internal class Assignment5
    {
        public static string GetUserInputs(string firstName,string lastName)
        {
            Console.WriteLine(lastName+","+firstName);
            string input = Console.ReadLine();
            return input;
        }
    }
}
