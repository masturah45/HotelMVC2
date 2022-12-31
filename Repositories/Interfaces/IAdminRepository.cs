using System.Collections.Generic;
using Hotel_MVC2.Models;

namespace Hotel_MVC2.Repositories
{
    public interface IAdminRepository
    {
        Admin CreateAdmin (Admin admin);
        Admin UpdateAdmin (Admin admin);
        void DeleteAdminUsingId (Admin adminId);
        Admin Login (string email, string password);
        Admin GetAdminId (string adminId);
        IList<Admin> GetAllAdmin();
    }
}