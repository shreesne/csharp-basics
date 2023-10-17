using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawnMowerRental
{
   public class LawnMower
    {
        //public int Id { get; set; }
        public string Model { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }

        

        public void RentalRecord()
         {
            Console.WriteLine("Enter rental date (yyyy-MM-dd):");
            RentalDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter return date (yyyy-MM-dd):");
            ReturnDate = DateTime.Parse(Console.ReadLine());
         }
        public int RentedDays
        {
            get
            {
                // Calculate the number of days between RentalDate and ReturnDate
                TimeSpan rentalPeriod = ReturnDate - RentalDate;
                return rentalPeriod.Days;
            }
        }
    }
}
