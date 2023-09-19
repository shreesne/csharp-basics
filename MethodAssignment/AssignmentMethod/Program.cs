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


            string userText1 = Assignment2.GetUserInput();
            Console.WriteLine("You entered: "+" "+"#"+userText1);

            string message = "Please enter number: ";
            string userText2 =Assignment3. GetUserInput(message);
            Console.WriteLine("You entered: " + userText2);







            string firstName = "Thomas";
            string lastName = "payne";
            string userText4= Assignment5.GetUserInputs(firstName,lastName);
            Console.WriteLine("Expected outcome :"+ userText4);

            Console.Write("enter the {word}:");
            var res=Console.ReadLine();
            var result= Assignment4.GetUserInput(res);
            Console.WriteLine("Expected output :"+result);

            



            Console.ReadKey();
        }

         

    }
}
