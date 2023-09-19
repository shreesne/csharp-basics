using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userText =Assignment1.GetUserInput();
            Console.WriteLine("You entered: " + userText);
            Console.WriteLine();

            string userText1 = Assignment2.GetUserInput();
            Console.WriteLine("You entered: "+" "+"#"+userText1);
            Console.WriteLine();

            string message = "Please enter number: ";
            string userText2 =Assignment3. GetUserInput(message);
            Console.WriteLine("You entered: " + userText2);
           Console.WriteLine();

            Console.Write("enter the {word}:");
            var res = Console.ReadLine();
            var result = Assignment4.GetUserInput(res);
            Console.WriteLine("expected output :" + result);
            Console.WriteLine();


            Assignment5.startAssignment5();








            Console.ReadKey();
        }

         

    }
}
