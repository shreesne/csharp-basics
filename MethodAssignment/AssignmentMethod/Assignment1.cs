using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMethod
{
    internal class Assignment1
    { 

        public static string GetUserInput()
        {
            Console.Write("Enter some text: ");
            string input = Console.ReadLine();
            return input;
        }
    }
}
