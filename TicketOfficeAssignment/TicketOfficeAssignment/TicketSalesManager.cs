using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketOfficeAssignment
{
    public class TicketSalesManager
    {
        public static List<Ticket> ticketList { get; set; }

        public TicketSalesManager()
        {
            ticketList = new List<Ticket>();
        }

        public static int GenerateTicketNumber()
        {
            int ticketNumber;
            Random random = new Random();
            ticketNumber = random.Next(1, 8001);
            return ticketNumber;
        }

        public Ticket AddTicket(Ticket ticket1)
        {
            ticketList.Add(ticket1);
            return ticket1;

        }

        public bool RemoveTicket(int Number)
        {
            Ticket ticketToRemove = ticketList.Find(t => t.Number == Number);
            if (ticketToRemove != null)
            {
                ticketList.Remove(ticketToRemove);
                //foreach (var ticket in ticketList)
                //{
                //   Console.WriteLine($"Age: {ticket.Age}, Ticket Number: {ticket.Number}, Place: {ticket.Place}");
                //}
                return true;
            }
            else
            {
                return false;
            }

        }

        public decimal SalesTotal()
        {

            decimal totalSales = ticketList.Sum(ti => ti.Price());
            return totalSales;
        }

        public int AmountOfTickets()
        {
            return ticketList.Count;

        }
    }
}
