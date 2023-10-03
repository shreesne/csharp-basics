namespace TicketOfficeAssignment
{
     class Program
    {
        public static string placeList = ",";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Ticket Booking System!");

            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Book a Ticket");
                Console.WriteLine("2. Exit");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    BookTicket();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Thank you for using the Ticket Booking System. Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
            }
            static void BookTicket()
            {
                TicketTaxCalculator taxCalculator = new TicketTaxCalculator();
                int age = taxCalculator.GetCustomerAge();
                var place = taxCalculator.GetCustomerPreference();
                Ticket ticket = new Ticket(age, place);
                ticket.Age = age;
                ticket.Place = place;
                int price = ticket.Price();
                decimal tax = ticket.Tax();
                Ticket ticket1 = new Ticket();
                int ticketNumber=ticket1.Number;

                if (place.ToString().ToLower() == "seated")
                {
                    Console.Write("Please check for seat number:");
                    int placeNumber = int.Parse(Console.ReadLine());
                    bool isPlacePresent = taxCalculator.CheckPlaceAvailability(placeList, placeNumber);
                    if (isPlacePresent)
                    {
                        Console.WriteLine($"{placeNumber} is present to book.");
                        placeList = taxCalculator.AddPlace(placeList, placeNumber);
                        ticket.Price();
                        ticket.Tax();
                        Console.WriteLine($"TicketDetails------>AGE:{age} years,PLACE:{place},SEAT NUMBER:{placeNumber},PRICE :{price},TOTAL(6%tax):{tax},TICKET NUMBER: {ticketNumber}");
                        Console.WriteLine();
                        Console.WriteLine($"Booked seats are :{placeList}");
                    }
                    else
                    {
                        Console.WriteLine($"{placeNumber} is NOT available please try again.");
                    }

                }
                else
                {
                    ticket.Price();
                    ticket.Tax();
                    Console.WriteLine($"TicketDetails------>AGE:{age} years,PLACE:{place},PRICE :{price},TOTAL(6%tax):{tax},TICKET NUMBER: {ticketNumber}");
                }
            }   
                   
        }
    }
}