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
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1)
                {
                    return SeatPreference.Seated;
                }
                else if (choice == 2)
                {
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

        }

        public bool CheckPlaceAvailability(string placeList, int placeNumber)
        {

            char delimiter = ','; // The space character as the delimiter
            string[] parts = placeList.Split(delimiter);
            return !parts.Any(i => i == placeNumber.ToString());

            // string searchNumber = $",{placeNumber},";
            //return !placeList.Contains(searchNumber);
        }
        public string AddPlace(string placeList, int placeNumber)
        {
            placeList += $"{placeNumber},";
            return placeList;
        }
       

    }
}
