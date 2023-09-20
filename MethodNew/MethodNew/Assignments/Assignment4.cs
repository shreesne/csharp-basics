using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodNew.Assignments
{
    internal class Assignment4
    {
        public static string startAssignment4()
        {
            Console.Write("enter the {word}:");
            var res = Console.ReadLine();
            return GetUserInput4(res);

        }
        public static string GetUserInput4(string word)
        {
            Console.Write($"Please enter a {word} :");
            string result = Console.ReadLine();
            Console.WriteLine("Expexcted result :"+ result);
            string output=Console.ReadLine();
            return output;

        }
    }
}
