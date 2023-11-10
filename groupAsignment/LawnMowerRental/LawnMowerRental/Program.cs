using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace LawnMowerRental
{
  public class Program
    {
        static List<Customer> customers = new List<Customer>();

        static List<LawnMower> lawnMowers = new List<LawnMower>();
        static  List<Rental> rentals = new List<Rental>();
        static void Main(string[] args)
        {
            
            InitializeLawnMowers();
            while (true)
            {
                Console.WriteLine("Lawn Mower Rental System");
                Console.WriteLine("1. Register New Customer");
                Console.WriteLine("2. Register Lawn Mower Rental");
                Console.WriteLine("3. Check Lawn Mower Inventory");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                          RegisterCustomer();
                            break;
                        case 2:
                           RegisterRental();
                            break;
                        case 3:
                            CheckInventory();
                            break;
                        case 4:
                           CustomerRecord();
                         //   Environment.Exit(0);
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
        static void InitializeLawnMowers()
        {
            // Initialize the list of lawn mowers with 15 available mowers
            for (int i = 1; i <= 15; i++)
            {
                lawnMowers.Add(new LawnMower { Model = $"LawnMower {i}", IsAvailable = true });
            }
        }

        static void RegisterCustomer()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter customer phone number: ");
            string phoneNumber = Console.ReadLine();
            customers.Add(new Customer { Name = name, PhoneNumber = phoneNumber });
            Console.WriteLine("Customer registered successfully.");
        }

        static void RegisterRental()
        {

            LawnMower lawnMower = new LawnMower();
            Console.Write("Enter customer phone number: ");
            string phoneNumber = Console.ReadLine();
            Customer customer = customers.Find(c => c.PhoneNumber == phoneNumber);
            if (customer != null)
            {
                Console.WriteLine("Available Lawn Mowers:");
                for (int i = 0; i < lawnMowers.Count; i++)
                {
                    if (lawnMowers[i].IsAvailable)
                    {
                         Console.WriteLine($"{i + 1}. {lawnMowers[i].Model}");
                    }
                }
                Console.WriteLine("Select a lawn mower to rent (enter its number): ");
                if (int.TryParse(Console.ReadLine(), out int mowerNumber) && mowerNumber >= 1 && mowerNumber <= lawnMowers.Count)
                {
                    LawnMower selectedMower = lawnMowers[mowerNumber - 1];
                    selectedMower.IsAvailable = false;
                    Console.WriteLine($"Rental of {selectedMower.Model} to {customer.Name} rented.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please select a valid lawn mower.");
                }
                lawnMower.RentalRecord();
                int rentedDays =lawnMower.RentedDays;
                Console.WriteLine($"Number of rented days: {rentedDays}");
             
            }
            else
            {
                Console.WriteLine("Customer not found. Please register first.");
            }
        }

        static void CheckInventory()
        {
            Console.WriteLine("Lawn Mower Inventory:");
            for (int i = 0; i < lawnMowers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {lawnMowers[i].Model} - {(lawnMowers[i].IsAvailable ? "Available" : "Rented")} ");
            }
        }

     static void CustomerRecord()
        {   Rental rental1=new Rental();
            rental1.Customer = customers[0];

            Console.WriteLine("Customer list with LawnMower Number :");

            foreach (var rental in rentals)
            {
                Console.WriteLine($"Customer Name: {rental.Customer.Name}");
                Console.WriteLine($"Lawn Mower Model: {rental.Mower.Model}");
                Console.WriteLine();
            }
        }

    }
}