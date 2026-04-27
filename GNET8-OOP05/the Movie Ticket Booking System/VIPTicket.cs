using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNET8_OOP05.the_Movie_Ticket_Booking_System
{
    public class VipTicket : Ticket
    {
        public bool HasLounge { get; set; }
        public decimal Fee { get; set; }

        public VipTicket(string movie, decimal basePrice, bool lounge, decimal fee)
            : base(movie, basePrice + fee)
        {
            HasLounge = lounge;
            Fee = fee;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(HasLounge ? "Yes" : "No")} | Fee: {Fee} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new VipTicket(MovieName, Price - Fee, HasLounge, Fee);
        }
    }
}
