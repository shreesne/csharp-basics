﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMethod
{
    internal class Assignment4
    {
        public static string startAssignment4()
        {
            Console.Write("enter the {word}:");
            var res = Console.ReadLine();
             return GetUserInput(res);
        }

        public static string GetUserInput(string word)
        { 
            Console.Write($"Please enter a {word} :");
            var result=Console.ReadLine();
           Console.WriteLine("Result is here:"+result);
            return result;
        }
        
    }
}