using VendingMachineApplication.Model;
using VendingMachineApplication.Service;

namespace VendingMachineApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachineService vendingMachine = new VendingMachineService();
            while (true)
            {
                Console.WriteLine("\nVending Machine Menu:");
                Console.WriteLine("1. Add Money");
                Console.WriteLine("2. Display Products");
                Console.WriteLine("3. Buy a Product");
                Console.WriteLine("4. Return Change");
                Console.WriteLine("5. Show Money Pool");
                Console.WriteLine("6. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter denomination: ");
                        int denomination;
                        if (!int.TryParse(Console.ReadLine(), out denomination))
                        {
                            Console.WriteLine("Invalid denomination. Money not accepted.");
                        }
                        else
                        {
                            vendingMachine.InsertMoney(denomination);
                        }
                        break;
                    case 2:
                        vendingMachine.ShowAll();
                        break;
                    case 3:
                        Console.Write("Enter the ID of the product: ");
                        string productId = Console.ReadLine();
                        vendingMachine.Purchase(productId);
                        break;
                    case 4:
                        vendingMachine.ReturnChange();
                        break;
                    case 5:
                        vendingMachine.ShowMoneyPool();
                        break;
                    case 6:
                        Console.WriteLine("Exiting the Vending Machine. Thank you for using it!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }

            }
        }
    }
}