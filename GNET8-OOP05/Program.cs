// See https://aka.ms/new-console-template for more information
using GNET8_OOP05.the_Movie_Ticket_Booking_System;

Console.WriteLine("Hello, World!");





#region Q1
// interface =>  defines a contract that a class must follow. It specifies what a class can do, not how it does it.
// Relying directly on concrete classes creates tight coupling. Interfaces introduce an abstraction layer, allowing you to depend on behavior rather than implementation.
// 1.Enable polymorphism without inheritance
// 2.Remove tight coupling between classes
// 3.Enable multiple inheritance (behavior)
#endregion





#region Q2
// a)
// The class provides one shared implementation for both interfaces.
// Both interface calls resolve to the same method → loss of intended behavior separat



// b) Use Explicit Interface Implementation to provide separate implementations for each interface.
// This allows:
//              Each interface method to have its own implementation
//              Resolves naming conflicts cleanly




// c) ❌ No, you cannot call it directly

//Translator translator = new Translator();
//((IEnglishSpeaker)translator).Greet(); 
//((IArabicSpeaker)translator).Greet(); 
#endregion






#region Q3
// shallow copy => A shallow copy copies the object but copies references for reference-type fields.
//                 Value types → copied independently
//                 Reference types → shared (same inner object)
//                 New outer object is created, but inner references point to the same objects


// Deep copy => A deep copy copies the object and all nested objects, creating fully independent duplicates.
//              Value types → copied independently (same as shallow)
//              Reference types → new objects created(not shared)
//              Must be implemented manually — clone each nested reference type
#endregion


#region Q4

//Dev - Testing
//QA - Testing
#endregion



#region Part2

        var cinema = new Cinema();
        cinema.Open();

        var t1 = new StandardTicket("Inception", 80, "A5");
        var t2 = new VipTicket("Avengers", 150, true, 50);
        var t3 = new ImaxTicket("Dune", 130, true);

        t1.Book();
        t2.Book();
        t3.Book();

        cinema.AddTicket(t1);
        cinema.AddTicket(t2);
        cinema.AddTicket(t3);

        cinema.PrintAllTickets();

        // Clone test
        Console.WriteLine("--- Clone Test ---");

        var clone = (VipTicket)t2.Clone();
        clone.MovieName = "Interstellar";

        Console.Write("Original : ");
        t2.Print();

        Console.Write("Clone    : ");
        clone.Print();

        Console.WriteLine();

        // Cancellation
        Console.WriteLine("--- After Cancellation ---");
        t1.Cancel();
        t1.Print();

        Console.WriteLine();

        // Helper
        BookingHelper.PrintAll(new IPrintable[] { t1, t2, t3 });

        cinema.Close();
 
#endregion