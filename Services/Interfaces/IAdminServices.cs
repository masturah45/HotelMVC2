using System.Collections.Generic;
using Hotel_MVC2.Models;

namespace Hotel_MVC2.Services. Interfaces
{
    public interface IAdminServices
    {
        Admin CreateAdmin (Admin admin);
        Admin UpdateAdmin (Admin admin);
        void DeleteAdminUsingId (string adminId);
        Admin Login (string email, string password);
        Admin GetAdminId (string adminId);
        IList<Admin> GetAllAdmin();
    }
}