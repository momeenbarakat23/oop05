using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNET8_OOP05.the_Movie_Ticket_Booking_System
{
    public abstract class Ticket : IPrintable, IBookable, ICloneable
    {
        private static int _counter = 0;

        public int TicketId { get; }
        public string MovieName { get; set; }
        public decimal Price { get; protected set; }
        public decimal PriceAfterTax => Price * 1.14m;

        public bool IsBooked { get; private set; }

        protected Ticket(string movieName, decimal price)
        {
            TicketId = ++_counter;
            MovieName = movieName;
            Price = price;
        }

        public bool Book()
        {
            if (IsBooked) return false;
            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked) return false;
            IsBooked = false;
            return true;
        }

        public abstract void Print();

        public abstract object Clone(); // Deep copy
    }
}
