using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNET8_OOP05.the_Movie_Ticket_Booking_System
{
    public class Cinema
    {
        private List<Ticket> _tickets = new List<Ticket>();

        public void Open() => Console.WriteLine("=== Cinema Opened ===\n");

        public void Close() => Console.WriteLine("\n=== Cinema Closed ===");

        public void AddTicket(Ticket ticket)
        {
            _tickets.Add(ticket);
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("--- All Tickets ---");
            foreach (var t in _tickets)
            {
                t.Print();
            }
            Console.WriteLine();
        }
    }
}
