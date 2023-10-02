using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using static TicketOfficeAssignment.SeatEnum;


namespace TicketOfficeAssignment
{
    public class Ticket
    {
        public int Age { get; set; }
        public int Number { get; set; }
        public SeatPreference Place { get; set; }

        public Ticket(int age, SeatPreference place)
        {
            this.Age = age;
            this.Place = place;
        }


        public int Price()
        {
               var place = Place.ToString().ToLower();
                int price = 0;
               if (Age > 0 && place == "seated" || place == "standing")
               {
                  if (Age <= 11)
                   {
                    return price = (place == "seated") ? 50 : 25;
                    }
                  else if (Age >= 12 && Age <= 64)
                   {
                    return price = (place == "seated") ? 170 : 110;
                    }
                   if (Age >= 65)
                    {
                    return price = (place == "seated") ? 100 : 60;
                   }
                }
               return price;
        }

        public decimal Tax()
        {
           int price1= Price();
           decimal tax = price1 + (price1 * 6 / 100);
           return tax;
        }

        public int TicketNumberGenerator()
        {
            Random rnd = new Random();
           int minVal = 1;
           int maxVal = 8000;
           return  rnd.Next(minVal, maxVal + 1);
        }
    }




}
