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
                Console.WriteLine();
                Console.Write("do you want to continue booking yes/no ");
                Continue = Console.ReadLine();
            }
        }
        private static void program1()
        {

            Console.WriteLine($"<-----Hello, Welcome to ticket booking----->");
            Console.WriteLine();
            int age = GetUserInput.GetCustomerAge();
            string place = GetUserInput.GetCustomerPreference();
            int price = GetUserInput.PriceSetter(age, place);
            decimal tax = GetUserInput.TaxCalculator(price);
            int ticketNo = GetUserInput.TicketNumberGenerator();
            if (place == "seated")
            {
                Console.Write("Please choose your seat number :");
                int placeNumber = int.Parse(Console.ReadLine());
                bool available = GetUserInput.CheckPlaceAvailability(placeList, placeNumber);

                if (available)
                {
                    Console.WriteLine($"{placeNumber} is present to book.");
                    placeList = GetUserInput.AddPlace(placeList, placeNumber);
                    Console.WriteLine();
                    Console.WriteLine($"TicketDetails------>AGE:{age} years,PLACE:{place},SEAT NUMBER:{placeNumber},PRICE :{price},TOTAL(6%tax):{tax},TICKET NUMBER: {ticketNo}");
                    Console.WriteLine() ;
                    Console.WriteLine($"Booked seats are :{placeList}");

                }
                else
                {
                    Console.WriteLine($"{placeNumber} is NOT available please try again");
                }
            }
            else if(place =="standing")
            {
                Console.WriteLine($"TicketDetails----->AGE:{age} years,PLACE:{place},PRICE:{price},TOTAL(6%tax):{tax},TICKET NUMBER: {ticketNo}");
            }
            else
            {
                Console.WriteLine("Invalid place preference please try again");
            }
        }
    }
    
}