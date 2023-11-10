using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentLawnMowerRenting
{
  public class Rental
    {
        public int RentalID { get; set; }
        public Customer Customer { get; set; }
        public LawnMower Mower { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int RentedDays
        {
            get
            {
                // Calculate the number of days between RentalDate and ReturnDate
                TimeSpan rentalPeriod = ReturnDate -StartDate;
                return rentalPeriod.Days;
            }
        }

    }
}
