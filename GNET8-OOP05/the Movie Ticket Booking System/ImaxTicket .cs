using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNET8_OOP05.the_Movie_Ticket_Booking_System
{
    public class ImaxTicket : Ticket
    {
        public bool Is3D { get; set; }

        public ImaxTicket(string movie, decimal price, bool is3D)
            : base(movie, price)
        {
            Is3D = is3D;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new ImaxTicket(MovieName, Price, Is3D);
        }
    }
}
