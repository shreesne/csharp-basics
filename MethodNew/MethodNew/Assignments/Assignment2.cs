﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodNew.Assignments
{
    internal class Assignment2
    {
        public static string GetUserInput2()
        {
            Console.Write("Enter some text: ");
            string input = Console.ReadLine();
            Console.WriteLine("Entered text is here with hashtags:"+" "+" #"+ input);
            string output = Console.ReadLine();
            return output;

        }
    }
}
