﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMethod
{
    internal class Assignment2
    {
        public static string GetUserInput2()
        {
            Console.Write("Enter some text: ");
            string input = Console.ReadLine();
            Console.WriteLine("Expected result is with hastag:"+" "+"#"+input);
            string output = Console.ReadLine();
            return output;
        }
    }
}
