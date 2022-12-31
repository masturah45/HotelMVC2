using System.Collections.Generic;
using Hotel_MVC2.Models;

namespace Hotel_MVC2.Repositories
{
    public interface IBookingRepository
    {
        Booking CreateBooking (Booking booking);
        Booking UpdateBooking (Booking booking);
        void DeleteBookingUsingId (Booking bookingNumber);
        Booking GetBookingById (string bookingNumber);
        IList<Booking> GetAllBooking ();
    }
}