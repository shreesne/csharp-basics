using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GroupAssignmentLawnMowerRenting
{
    public class LawnMowerRentalApp
    {
        private List<Customer> customers = new List<Customer>();
        private List<LawnMower> lawnMowers = new List<LawnMower>();
        private List<Rental> rentals = new List<Rental>();
        public void RegisterCustomer()
        {
            Customer newCustomer = new Customer();

            Console.WriteLine("Enter customer details:");
            Console.Write("Customer Name: ");
            newCustomer.Name = Console.ReadLine();

            Console.Write("Contact Details: ");
            newCustomer.PhoneNumber = Console.ReadLine();

            newCustomer.CustomerID = GenerateUniqueCustomerID();

            customers.Add(newCustomer);
            Console.WriteLine($"{newCustomer.Name} registered successfully with Customer Id - {newCustomer.CustomerID} .");
        }

        //private int GenerateUniqueCustomerID()
        //{

        //    Random random = new Random();
        //    return random.Next(1000, 2000);
        //}
        private static int uniqueNumber = 100;

        public int GenerateUniqueCustomerID()
        {
            return uniqueNumber++;
        }
        public void RegisterLawnMower()
        {
            LawnMower newLawnMower = new LawnMower();

            Console.WriteLine("Enter lawn mower details:");
            Console.Write("Lawn Mower Model: ");
            newLawnMower.Model = Console.ReadLine();

            // newLawnMower.MowerID = GenerateUniqueMowerID();
            newLawnMower.MowerID = SelectMowerId();

            newLawnMower.Available = true;

            lawnMowers.Add(newLawnMower);
            Console.WriteLine($"{newLawnMower.Model}  with Mower Id - {newLawnMower.MowerID} .");

        }

        private int SelectMowerId()
        {
            Console.WriteLine("please enter mower Id (1-15)");
            int mowerId=int.Parse(Console.ReadLine());
            return mowerId;
        }
     
        public void RegisterRental()
        {
            Rental newRental = new Rental();

            // Check if there are available mowers for rent.
            if (lawnMowers.Any(mower => mower.Available))
            {
                Console.WriteLine("Enter rental details:");

                Console.Write("Customer ID: ");
                int customerID = int.Parse(Console.ReadLine());

                // Check if the customer exists.
                Customer customer = customers.FirstOrDefault(c => c.CustomerID == customerID);
                if (customer == null)
                {
                    Console.WriteLine("Customer not found. Please register the customer first.");
                    return;
                }

                Console.Write("Lawn Mower ID: ");
                int mowerID = int.Parse(Console.ReadLine());

                // Check if the mower exists and is available for rent.
                LawnMower mower = lawnMowers.FirstOrDefault(m => m.MowerID == mowerID && m.Available);
                if (mower == null)
                {
                    Console.WriteLine("Lawn mower not found or already rented.");
                    return;
                }

                Console.Write("Start Date (YYYY-MM-DD): ");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
                {
                    Console.WriteLine("Invalid date format. Please use YYYY-MM-DD.");
                    return;
                }

                Console.Write("Return Date (YYYY-MM-DD): ");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime returnDate))
                {
                    Console.WriteLine("Invalid date format. Please use YYYY-MM-DD.");
                    return;
                }

                // Assign rental details.
                newRental.Customer = customer;
                newRental.Mower = mower;
                newRental.StartDate = startDate;
                newRental.ReturnDate = returnDate;

                // Update mower availability.
                mower.Available = false;

                // Add the new rental to the list of rentals.
                rentals.Add(newRental);
                int rentedDays = newRental.RentedDays;
                Console.WriteLine($"Number of rented days: {rentedDays}");
            }
            else
            {
                Console.WriteLine("No available lawn mowers for rent at the moment.");
            }
        }

        public void GetActiveRentals()
        {
          
            Customer customer = new Customer();
            LawnMower lawnMower = new LawnMower();
            customers.Add(customer);
            lawnMowers.Add(lawnMower);
            Rental rental = new Rental
            {
                Customer = customer,
                Mower = lawnMower
            };
            rentals.Add(rental);
            foreach (var rental1 in rentals)
            {
                Console.WriteLine($"Customer Name: {rental1.Customer.Name} Model: {rental1.Mower.Model} MowerID: {rental1.Mower.MowerID}");
            }

        }

       
    }
}
