namespace TicketCalculator
{
    class Program
    {
        public static string placeList = "";
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
            Console.Write("Enter your age: ");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine();
            if(age>=0)
            {
                Console.Write("Your prefernce to seat[yes/no]: ");
                string place = Console.ReadLine();
                Console.WriteLine();
                if (place=="yes"||place=="no")
                {
                    TicketCalculator obj = new TicketCalculator();
                    Console.Write("Please check for ticket availablity:");
                    int placeNumber = int.Parse(Console.ReadLine());
                    bool isPlacePresent = obj.CheckPlaceAvailability(placeList, placeNumber);
                    if (isPlacePresent)
                    {
                        Console.WriteLine($"{placeNumber} is NOT available to book choose another.");
                    }
                    else
                    {
                        Console.WriteLine($"{placeNumber} is present to book.");

                        placeList = obj.AddPlace(placeList, placeNumber);
                    }


                    //  placeList = obj.CheckPlaceAvailability(placeList, placeNumber);
                    //var  bookedSeats= obj.AddPlace(placeList, placeNumber);
                    Console.WriteLine("Booked seats are :" + placeList);
                    var price = obj.PriceSetter(age, place);
                    Console.WriteLine($"Ticket price before tax:{price} SEK(kronor)");
                    Console.WriteLine();
                    var priceAfterTax = obj.TaxCalculator(price);
                    Console.WriteLine($"Ticket price after tax:{priceAfterTax} SEK(kronor)");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid place input");
                }
            }
          else { Console.WriteLine("Invalid age input"); }

            TicketCalculator obj1 = new TicketCalculator();
            int ticketNo= obj1.TicketNumberGenerator();
            Console.WriteLine("Your ticket number is :" + ticketNo);
        }
    }
}