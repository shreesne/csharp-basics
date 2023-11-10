namespace GroupAssignmentLawnMowerRenting
{
    public class Program
    {
      static void Main(string[] args)
        { 
            LawnMowerRentalApp app=new LawnMowerRentalApp();

            while (true)
            {
                Console.WriteLine("Lawn Mower Rental System");
                Console.WriteLine("1. Register New Customer");
                Console.WriteLine("2. Register Lawn Mower Rental");
                Console.WriteLine("3. Rental Details");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                
                
                {
                    switch (choice)
                    {
                        case 1:
                          app.RegisterCustomer();
                            break;
                        case 2:
                           app.RegisterLawnMower();
                            break;
                        case 3:
                           app.RegisterRental();
                            break;
                        case 4:
                         app.GetActiveRentals();

                           // Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid option (1-4).");
                }
            }


        }
    }
}