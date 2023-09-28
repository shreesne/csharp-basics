using System.Diagnostics;

namespace TicketUserInput
{
    internal class Program
    {
        public static string placeList = ",";
        static void Main(string[] args)
        {
            var Continue = "yes";
            while (Continue.ToLower() == "yes")
            {

                program1();
                Console.Write("do you want to continue booking yes/no ");
                Continue = Console.ReadLine();
            }
        }
        private static void program1()
        {

            Console.WriteLine("Hello, World!");
            int age = GetUserInput.GetCustomerAge();
            string place = GetUserInput.GetCustomerPreference();
           
            int price = GetUserInput.PriceSetter(age, place);
            decimal tax = GetUserInput.TaxCalculator(price);
            int ticketNo = GetUserInput.TicketNumberGenerator();
            if (place == "seated")
            {
                Console.WriteLine("Please choose your seat number :");
                int placeNumber = int.Parse(Console.ReadLine());
                bool available = GetUserInput.CheckPlaceAvailability(placeList, placeNumber);
                // Console.WriteLine("Please choose your seat number :");
                // int placeNumber = int.Parse(Console.ReadLine());

                if (available)
                {
                    Console.WriteLine($"{placeNumber} is present to book.");
                    placeList = GetUserInput.AddPlace(placeList, placeNumber);
                    Console.WriteLine("TicketDetails :");
                    Console.WriteLine($"Age:{age} years,Place preference :{place},Your seat number is:{placeNumber},Price :{price},Total price after tax:{tax},Ticket number is: {ticketNo}");
                   // Console.WriteLine($"Age:{age} years");
                   // Console.WriteLine($"Place preference :{place}");
                  //  Console.WriteLine($"Your seat number is:{placeNumber}");
                  //  Console.WriteLine($"Price :{price}");
                   // Console.WriteLine($"Total price after tax:{tax}");
                 //  Console.WriteLine($"Ticket number is: {ticketNo}");
                    Console.WriteLine($"Booked seats are :{placeList}");

                }
                else
                {
                    Console.WriteLine($"{placeNumber} is NOT available please try again");

                }
            }
            else
            {
                Console.WriteLine("TicketDetails :");
                Console.WriteLine($"Age:{age} years,Place preference :{place},Price :{price},Total price after tax:{tax},Ticket number is: {ticketNo}");
                //Console.WriteLine($"Place preference :{place}");
                //Console.WriteLine($"Price :{price}");
                //Console.WriteLine($"Total price after tax:{tax}");
                //Console.WriteLine($"Ticket number is: {ticketNo}");
               
            }

           
        }
    }
    
}