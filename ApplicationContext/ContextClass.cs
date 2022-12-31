using Hotel_MVC2.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_MVC2.ApplicationContext
{
    public class ContextClass : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;port=3306;Database=HotelMVC2;Uid=root;Pwd=masturah");
        }

        public DbSet<Admin> Admins {get;set;}
        public DbSet<Customer> Customers {get;set;}
        public DbSet<Booking> Bookings {get;set;}
        public DbSet<Room> Rooms {get;set;}
        
    }
}