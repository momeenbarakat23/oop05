using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNET8_OOP05.the_Movie_Ticket_Booking_System
{
    public static class BookingHelper
    {
        public static void PrintAll(IPrintable[] items)
        {
            Console.WriteLine("--- BookingHelper.PrintAll ---");
            foreach (var item in items)
            {
                item.Print();
            }
        }
    }
}
