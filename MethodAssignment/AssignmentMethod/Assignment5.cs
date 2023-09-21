using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMethod
{
    public class Assignment5
    {

        public static string startAssignment5()
        {
            
            string firstname = "Thomas";
            
            string lastname = "Payne";

            return GetUserInputs(firstname, lastname);
        }
        public static string GetUserInputs(string firstName,string lastName)
        {
            Console.WriteLine("Result is:"+lastName+","+firstName);
            string input = Console.ReadLine();
            return input;
        }
    }
}
