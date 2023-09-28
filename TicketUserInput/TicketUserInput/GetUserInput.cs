using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TicketUserInput
{
    internal class GetUserInput
    {
        public static int GetCustomerAge()
        {
            Console.Write("Please enter your age in digits :");
            
            string inputAge = Console.ReadLine();
          //  int age = int.Parse(inputAge);
            bool containsNumber = true;
            if (inputAge != null && inputAge.Length >= 1 && inputAge.Length <= 3)
            {
                foreach (char c in inputAge)
                {
                    if (!char.IsDigit(c))
                    {
                        containsNumber = false;
                        break;
                    }
                }
                if (containsNumber)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Please enter your valid age.");
                    return GetCustomerAge();
                }
            }
            else
            {
                Console.WriteLine("Please enter your valid age.");
                return GetCustomerAge();

            }
              int age = int.Parse(inputAge);
            return age;
        }

        public static string GetCustomerPreference()
        {
            Console.WriteLine("Select [standing]ticket/[seated] ticket :");
            string place = Console.ReadLine();
            string placeLower = place.ToLower();
            //if (placeLower == "seated" || placeLower == "standing")
            //{
            //    if (placeLower == "seated")
            //    {
            //        Console.WriteLine("You chosen to book seat.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("choose to stand");
            //    }
            //}
            return placeLower;
        }
        public static bool CheckPlaceAvailability(string placeList, int placeNumber)
        {
           // return placeList.Contains(("," + placeNumber + ",").ToString());
           string searchNumber=$",{placeNumber},";
            return !placeList.Contains(searchNumber);


        }
        public static string AddPlace(string placeList, int placeNumber)
        {
            placeList += $"{placeNumber},";
           // placeList = placeList + Convert.ToString(placeNumber) + ",";
            return placeList;

        }
        public static int PriceSetter(int age, string place)
        {
            int price=0;
            if (age > 0 && place=="seated"||place=="standing")
            {
                if (age <= 11) 
                {
                    price = (place == "seated") ? 50 : 25;
                }
              else  if (age>=12 && age<=64)
                {
                    price = (place == "seated") ? 170 : 110;
                }
                if (age>=65)
                {
                    price = (place == "seated") ? 100 : 60;
                }
            }
            
            return price;
        }
        public static decimal TaxCalculator(int Price)
        {
           
          decimal  tax = Price + (Price * 6 / 100);
            return tax;
        }
        public static int TicketNumberGenerator()
        {
            Random rnd = new Random();
            int minVal = 1;
            int maxVal = 8000;
            return rnd.Next(minVal, maxVal + 1);
        }
    }
}
