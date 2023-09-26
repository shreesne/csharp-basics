using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCalculator
{

    public class TicketCalculator
    {
        public bool CheckPlaceAvailability(string placeList, int placeNumber)
        {
            return placeList.Contains(placeNumber.ToString());


        }
        public string AddPlace(string placeList, int placeNumber)
        {

            placeList = placeList + Convert.ToString(placeNumber) + ",";
            return placeList;

        }
        public int PriceSetter(int age, string place)
        {
            int price = 0;
            bool isSeating = place.Equals("yes", StringComparison.OrdinalIgnoreCase);
            if (age <= 11)
            {

                if (isSeating)
                {
                    return price = 50;
                }
                else
                {
                    return price = 25;
                }
            }
            else if (age >= 12 && age <= 64)
            {
                if (isSeating)
                {
                    return price = 170;
                }
                else
                {
                    return price = 110;
                }
            }
            else if (age >= 65)
            {
                if (isSeating)
                {
                    return price = 100;
                }
                else
                {
                    return price = 60;
                }
            }
            return price;
        }

       

        public decimal TaxCalculator (int Price) 
        {
            decimal tax;
            tax = Price + (Price * 6 / 100);
            return tax;
        }

        public int TicketNumberGenerator()
        {
            Random rnd = new Random();
            int minVal = 1;
            int maxVal = 8000;
           return rnd.Next(minVal,maxVal+1);
        }
    }
}