﻿using System;
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
            Number = TicketSalesManager.GenerateTicketNumber();
            Age = age;
            Place = place;
        }


        public int Price()
        {

            int price = 0;
            if (Age > 0 && Place == SeatPreference.Seated || Place == SeatPreference.Standing)
            {
                if (Age <= 11)
                {
                    return price = (Place == SeatPreference.Seated) ? 50 : 25;
                }
                else if (Age >= 12 && Age <= 64)
                {
                    return price = (Place == SeatPreference.Seated) ? 170 : 110;
                }
                if (Age >= 65)
                {
                    return price = (Place == SeatPreference.Seated) ? 100 : 60;
                }
            }
            return price;
        }

        //public decimal Tax()
        //{
        //   int price1= Price();
        //   decimal tax = price1 + (price1 * 6 / 100);
        //   return tax;
        //}

        public Ticket()
        {   
          TicketSalesManager.GenerateTicketNumber();
        }
    }
}
