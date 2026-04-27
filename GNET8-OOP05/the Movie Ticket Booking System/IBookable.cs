using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNET8_OOP05.the_Movie_Ticket_Booking_System
{
    public interface IBookable
    {
        bool Book();
        bool Cancel();
        bool IsBooked { get; }
    }
}
