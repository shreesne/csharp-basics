using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMethod
{
    internal class Assignment3
    {
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message); 
            string input=Console.ReadLine();    
            return input;
        }
    }
}
