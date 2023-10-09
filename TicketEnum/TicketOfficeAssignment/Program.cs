using System.Net.Sockets;
using static TicketOfficeAssignment.SeatEnum;

namespace TicketOfficeAssignment
{
     class Program
    {
        public static string placeList = "";

        TicketSalesManager ticketSalesManager = null;
        public Program()
        {
            ticketSalesManager = new TicketSalesManager();
        }


        static void Main(string[] args)
        {
            Program objPro = new Program();
            Console.WriteLine("Welcome to the Ticket Booking System!");
            objPro.startBooking(objPro);
        }
        void startBooking(Program objPro)
        {
            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1.Add a Ticket\t  2.Remove ticket\t 3.Booking Details\t4.Exit");
              //  Console.WriteLine("2.Remove a ticket");
              //  Console.WriteLine("3.Show Booking Details");
              //  Console.WriteLine("4.Exit");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    objPro.BookTicket();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Please enter ticket number to remove from list :");
                    int removeTicket = int.Parse(Console.ReadLine());


                    bool removed = ticketSalesManager.RemoveTicket(removeTicket);
                    if (removed)
                    {
                        Console.WriteLine("remove successfully");

                    }
                    else
                    {
                        Console.WriteLine("Ticket number not found.");
                    }

                }
                else if (choice == 3)
                {
                    
                    Console.WriteLine($"TICKET COUNT:-{ticketSalesManager.AmountOfTickets()} and TOTAL COST:-{ticketSalesManager.SalesTotal()}");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thank you for Booking !");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
            }
        }
        private void BookTicket()
        {

            TicketTaxCalculator taxCalculator = new TicketTaxCalculator();
            int age = taxCalculator.GetCustomerAge();
            var place = taxCalculator.GetCustomerPreference();
            
            Ticket ticket = new Ticket(age, place);
            ticket.Age = age;
            ticket.Place = place;
            int price = ticket.Price();
           // decimal tax = ticket.Tax();

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
                  //  ticket.Tax();
                    ticketSalesManager.AddTicket(ticket);
                     Console.WriteLine($"TicketDetails------>AGE:{age},PLACE:{place},SEAT NUMBER:{placeNumber},PRICE :{price}");
                    Console.WriteLine($"Generated ticket numbers are :{ticket.Number}");

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
              //  ticket.Tax();
                ticketSalesManager.AddTicket(ticket);
                Console.WriteLine($"TicketDetails------>AGE:{age} years,PLACE:{place},PRICE :{price}");
                Console.WriteLine($"Generated ticket numbers are :{ticket.Number}");
            }
        }
    }
}