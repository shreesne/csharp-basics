using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMethod
{
    internal class Assignment4
    {


        public static string GetUserInput(string word)
        { 
            Console.Write($"Please enter a {word} :");
            var res=Console.ReadLine();
            return res;

        }
        
    }
}