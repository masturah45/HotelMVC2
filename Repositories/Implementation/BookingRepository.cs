using System.Collections.Generic;
using System.Linq;
using Hotel_MVC2.ApplicationContext;
using Hotel_MVC2.Models;

namespace Hotel_MVC2.Repositories.Implementation
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ContextClass _context;

        public BookingRepository (ContextClass context)
        {
            _context = context;
        }

        public Booking CreateBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
            return booking;
        }

        public void DeleteBookingUsingId(Booking bookingNumber)
        {
            _context.Bookings.Remove(bookingNumber);
            _context.SaveChanges();
        }

        public IList<Booking> GetAllBooking()
        {
            return _context.Bookings.ToList();
        }

        public Booking GetBookingById(string bookingNumber)
        {
            var booking = _context.Bookings.SingleOrDefault(a => a.BookingNumber == bookingNumber);
            return booking;
        }

        public Booking UpdateBooking(Booking booking)
        {
            _context.Bookings.Update(booking);
            _context.SaveChanges();
            return booking;
        }
    }
}