namespace TicketCalculator
{
    class Program
    {
        static void Main(string[] args)
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