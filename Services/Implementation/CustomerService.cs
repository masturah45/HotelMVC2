using System;
using System.Collections.Generic;
using System.IO;
using Hotel_MVC2.Interfaces;
using Hotel_MVC2.Models;
using Hotel_MVC2.Repositories;

namespace Hotel_MVC2.Services.Implementation
{
    public class CustomerService : ICustomerServices
    {
        private readonly ICustomerRepository _repo;

        public CustomerService (ICustomerRepository repo)
        {
            _repo = repo;
        }

        public Customer CreateCustomer(Customer customer)
        {
            var rand = new Random();
            customer.CustomerNumber = "FIVESTARS-CUSTOMER-"+rand.Next(0, 9).ToString()+rand.Next(50, 99).ToString()+"-" +customer.FirstName[0]+customer.FirstName[1]+customer.FirstName[2]+rand.Next(0, 9).ToString();
            return _repo.CreateCustomer(customer);
        }

        public void DeleteCustomerUsingId(string customerNumber)
        {
            var admin = _repo.GetCustomerId(customerNumber);
            _repo.DeleteCustomerUsingId(admin);
        }

        public IList<Customer> GetAllCustomer()
        {
            return _repo.GetAllCustomer();
        }

        public Customer GetCustomerId(string customerNumber)
        {
            return _repo.GetCustomerId(customerNumber);
        }

        public Customer Login(string email, string password)
        {
            return _repo.Login(email, password);
        }

        public Customer UpdateCustmer(Customer customer)
        {
            var customerr = _repo.GetCustomerId(customer.CustomerNumber);
            if (customerr == null)
            {
                throw new DirectoryNotFoundException();
            }

            customerr.FirstName = customer.FirstName ?? customerr.FirstName;
            customerr.LastName = customer.LastName ?? customerr.LastName;
            customerr.Email = customer.Email ?? customerr.Email;
            customerr.PassWord = customer.PassWord ?? customerr.PassWord;
            customerr.PhoneNumber = customer.PhoneNumber ?? customerr.PhoneNumber;
            customerr.Address = customer.Address ?? customerr.Address;
            customerr.Age = customer.Age != customerr.Age? customer.Age : customerr.Age;
            customerr.Gender = customer.Gender;
            return _repo.UpdateCustmer(customerr);
            
        }
    }
}