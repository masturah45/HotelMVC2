using System.Collections.Generic;
using System.Linq;
using Hotel_MVC2.ApplicationContext;
using Hotel_MVC2.Models;

namespace Hotel_MVC2.Repositories.Implementation
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ContextClass _context;

        public AdminRepository (ContextClass context)
        {
            _context = context;
        }

        public Admin CreateAdmin(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
            return admin;
        }

        public void DeleteAdminUsingId(Admin adminId)
        {
            _context.Admins.Remove(adminId);
            _context.SaveChanges();
        }

        public Admin GetAdminId(string adminId)
        {
            var admin = _context.Admins.SingleOrDefault(a => a.AdminId == adminId);
            return admin;
        }

        public IList<Admin> GetAllAdmin()
        {
            return _context.Admins.ToList();
        }

        public Admin Login(string email, string password)
        {
            return _context.Admins.SingleOrDefault(a => a.Email == email && a.Password == password);
        }

        public Admin UpdateAdmin(Admin admin)
        {
            _context.Admins.Update(admin);
            _context.SaveChanges();
            return admin;
        }
    }
}