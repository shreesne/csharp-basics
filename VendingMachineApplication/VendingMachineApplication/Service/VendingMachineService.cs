using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Linq;
using VendingMachineApplication.Model;
using System.Runtime.Intrinsics.X86;

namespace VendingMachineApplication.Service
{

  public class VendingMachineService : IVending
    {
        private List<Product> products = new List<Product>();
           //{
           //      new Drink("D1","Coffee",25,"Chocolate"),
           //      new Drink("D2","Soda",25,"Orange"),
           //      new Snack("S1","Chips",10,120),
           //      new Snack("S2","Clif Bars",50,130),
           //      new Chocolate("C1","Merci",10,"vanilla"),
           //      new Chocolate("C2","Marabou",35,"chocolate")
           // };

        int[] validDenominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        private Dictionary<int, int> moneyPool = new Dictionary<int, int>();

        private Dictionary<int, int> blankMoneyPool = new Dictionary<int, int>();
        public VendingMachineService()
        {
            foreach (var item in validDenominations)
            {
                moneyPool.Add(item, 0);
                blankMoneyPool.Add(item, 0);
            }
            products.Add(new Drink("D1", "Coffee", 25, "Chocolate"));
            products.Add(new Drink("D2", "Soda", 25, "Orange"));
            products.Add(new Snack("S1", "Chips", 10, 120));
            products.Add(new Snack("S2", "Clif Bars", 50, 130));
            products.Add(new Chocolate("C1", "Merci", 10, "vanilla"));
            products.Add(new Chocolate("C2", "Marabou", 35, "chocolate"));
        }
        public List<string> ShowAll()
        {
            Console.WriteLine("Available products:");
            List<string> productInfo = new List<string>();
            Console.WriteLine("Id | Name |Price | Quantity");
            foreach (var product in products)
            {
                productInfo.Add($"{product.Id},{product.Name},{product.Price}");

                Console.WriteLine($"{product.Id} | {product.Name} | {product.Price} ");
            }
            return productInfo;
        }
        public void InsertMoney(int denomination)
        {
            if (moneyPool.ContainsKey(denomination))
            {
                moneyPool[denomination]++;
                Console.WriteLine($"Added {denomination}kr to the money pool.");
            }
            else
            {
                Console.WriteLine("Invalid denomination. Money not accepted.");
            }
        }
        public void ShowMoneyPool()
        {
            Console.WriteLine("Money pool:");
            foreach (var pair in moneyPool)
            {
                Console.WriteLine($"{pair.Key}kr - {pair.Value}");
            }
        }
        public int CalculateMoneyPoolTotal()
        {
            int total = 0;
            foreach (var pair in moneyPool)
            {
                total += pair.Value * pair.Key;
            }
            return total;
        }
        public Product Purchase(string productId)
        {
            Product product = products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                int price = product.Price;
                int Total = CalculateMoneyPoolTotal();
                if (price <= Total)
                {
                    var remainingMoney = Total - price;
                    var changeWithDenomination = DivideMoney(remainingMoney);
                    moneyPool = EndTransactions(blankMoneyPool, changeWithDenomination);
                    product.Use();
                    product.Examine();
                    return product;
                }
                else
                {
                    Console.WriteLine("Not enough money to buy the selected product.");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Product not found in the vending machine.");
                return null;
            }
        }
        public Dictionary<int, int> DivideMoney(int amount)
        {
            int[] denominations = validDenominations.Reverse().ToArray();
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (int denomination in denominations)
            {
                int count = amount / denomination;
                if (count > 0)
                {
                    result[denomination] = count;
                    amount %= denomination;
                }
            }
            return result;
        }

        public  Dictionary<TKey, TValue> EndTransactions<TKey, TValue>(Dictionary<TKey, TValue> dict1, Dictionary<TKey, TValue> dict2, bool overwriteExistingKeys = true)
        {
            Dictionary<TKey, TValue> result = new Dictionary<TKey, TValue>(dict1);
            foreach (var kvp in dict2)
            {
                if (result.ContainsKey(kvp.Key))
                {
                    if (overwriteExistingKeys)
                    {
                        result[kvp.Key] = kvp.Value;
                    }
                }
                else
                {
                    result[kvp.Key] = kvp.Value;
                }
            }
            return result;
        }

        public void ReturnChange()
        {
            Console.WriteLine($"Returning change: {CalculateMoneyPoolTotal()}kr");
        }
    }
}