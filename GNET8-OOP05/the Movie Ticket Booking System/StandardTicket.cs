using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNET8_OOP05.the_Movie_Ticket_Booking_System
{
    public class StandardTicket : Ticket
    {
        public string Seat { get; set; }

        public StandardTicket(string movie, decimal price, string seat)
            : base(movie, price)
        {
            Seat = seat;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {Seat} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new StandardTicket(MovieName, Price, Seat);
        }
    }
}
