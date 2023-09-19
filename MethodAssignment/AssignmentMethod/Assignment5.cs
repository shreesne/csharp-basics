using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMethod
{
    internal class Assignment5
    {

        public static string startAssignment5()
        {
            Console.WriteLine("firstName:");
            string firstname = Console.ReadLine();
            Console.WriteLine("lastname:");
            string lastname = Console.ReadLine();

            return GetUserInputs(firstname, lastname);
        }
        public static string GetUserInputs(string firstName,string lastName)
        {
            Console.WriteLine("Result is:" + lastName + " , " + firstName);
            string input = Console.ReadLine();
            return input;
        }
    }
}
