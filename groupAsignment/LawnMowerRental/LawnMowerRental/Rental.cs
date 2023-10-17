using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawnMowerRental
{

    public class Rental
    {
       public List<Rental> rentals = new List<Rental>();

        public Customer Customer { get; set; }
        public LawnMower Mower { get; set; }

     

    }
}