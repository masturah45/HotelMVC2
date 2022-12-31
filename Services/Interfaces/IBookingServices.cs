using System.Collections.Generic;
using Hotel_MVC2.Models;

namespace Hotel_MVC2.Interfaces
{
    public interface IBookingServices
    {
        Booking CreateBooking (Booking booking);
        Booking UpdateBooking (Booking booking);
        void DeleteBookingUsingId (string bookingNumber);
        Booking GetBookingById (string bookingNumber);
        IList<Booking> GetAllBooking ();
    }
}