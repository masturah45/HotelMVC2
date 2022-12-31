using System;
using System.Collections.Generic;
using System.IO;
using Hotel_MVC2.Models;
using Hotel_MVC2.Repositories;
using Hotel_MVC2.Services.Interfaces;

namespace Hotel_MVC2.Services.Implementation
{
    public class AdminService : IAdminServices
    {
        private readonly IAdminRepository _repo;

        public AdminService (IAdminRepository repo)
        {
            _repo = repo;
        }

        public Admin CreateAdmin(Admin admin)
        {
            var rand = new Random();
            admin.AdminId = "FIVESTARS-ADMIN-"+rand.Next(0, 9).ToString()+rand.Next(50, 99).ToString()+"-" +admin.FirstName[0]+admin.FirstName[1]+admin.FirstName[2]+rand.Next(0, 9).ToString();
            return _repo.CreateAdmin(admin);
        }

        public void DeleteAdminUsingId(string adminId)
        {
            var admin = _repo.GetAdminId(adminId);
            _repo.DeleteAdminUsingId(admin);
        }

        public Admin GetAdminId(string adminId)
        {
            return _repo.GetAdminId(adminId);
        }

        public IList<Admin> GetAllAdmin()
        {
            return _repo.GetAllAdmin();
        }

        public Admin Login(string email, string password)
        {
            return _repo.Login(email, password);
        }

        public Admin UpdateAdmin(Admin admin)
        {
            var adminn = _repo.GetAdminId(admin.AdminId);
            if (adminn == null)
            {
                throw new DirectoryNotFoundException();
            }

            adminn.FirstName = admin.FirstName ?? adminn.FirstName;
            adminn.LastName = admin.FirstName ?? adminn.LastName;
            adminn.Email = admin.Email ?? adminn.Email;
            adminn.Password = admin.Password ?? adminn.Password;
            adminn.Age = admin.Age != adminn.Age? admin.Age : adminn.Age;
            adminn.Address = admin.Address ?? adminn.Address;
            adminn.Gender = admin.Gender;
            return _repo.UpdateAdmin(adminn);
        }
    }
}