using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TicketOfficeAssignment.seatEnum;

namespace TicketOfficeAssignment
{
  public class TicketTaxCalculator
    {
        public int GetCustomerAge()
        {
            Console.Write("Please enter your age in digits :");

            string inputAge = Console.ReadLine();
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

        public SeatPreference GetCustomerPreference()
        {
            Console.WriteLine("Please enter your choice as 1 OR 2 :");

            Console.WriteLine("1. Seated");
            Console.WriteLine("2. Standing");

          //var preference = SeatPreference.Standing;
            

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
      {
                if (choice == 1)
                {
                    //preference = SeatPreference.Seated;
                    // Console.WriteLine($"You selected {preference}.");
                    return SeatPreference.Seated;
                }
                else if (choice == 2)
                {
                    //onsole.WriteLine($"You selected {preference}.");
                    // return preference;
                    return SeatPreference.Standing;
                }
                else
                {
                    Console.WriteLine("please select your prefernce.");
                   return GetCustomerPreference();
                }
            }
            else
            {
                Console.WriteLine("please select your prefernce.");
                return GetCustomerPreference();
            }
         // return preference;


            //string place = Console.ReadLine();
            //string placeLower = place.ToLower();

            //if (placeLower == "standing")
            //{
            //    return placeLower;
            //}
            //else if(placeLower=="seated")
            //{
            //    return placeLower;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid place preference");
            //    return GetCustomerPreference();
            //}
            //return placeLower;
        }
        public  bool CheckPlaceAvailability(string placeList, int placeNumber)
        {
            string searchNumber = $",{placeNumber},";
            return !placeList.Contains(searchNumber);
        }
        public  string AddPlace(string placeList, int placeNumber)
        {
            placeList += $"{placeNumber},";
            return placeList;
        }
        public  int PriceSetter(int age, SeatPreference preference)
        {
            var place = preference.ToString().ToLower();
            int price = 0;
            if (age > 0 && place == "seated" || place == "standing")
            {
                if (age <= 11)
                {
                    price = (place == "seated") ? 50 : 25;
                }
                else if (age >= 12 && age <= 64)
                {
                    price = (place == "seated") ? 170 : 110;
                }
                if (age >= 65)
                {
                    price = (place == "seated") ? 100 : 60;
                }
            }

            return price;
        }
        public  decimal TaxCalculator(int Price)
        {
            decimal tax = Price + (Price * 6 / 100);
            return tax;
        }
        public  int TicketNumberGenerator()
        {
            Random rnd = new Random();
            int minVal = 1;
            int maxVal = 8000;
            return rnd.Next(minVal, maxVal + 1);
        }

      

    }
}
