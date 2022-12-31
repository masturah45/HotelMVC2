using System.Collections.Generic;
using Hotel_MVC2.Models;

namespace Hotel_MVC2.Interfaces
{
    public interface ICustomerServices
    {
        Customer CreateCustomer (Customer customer);
        Customer UpdateCustmer (Customer customer);
        void DeleteCustomerUsingId (string customerNumber);
        Customer Login (string email, string password);
        Customer GetCustomerId (string customerNumber);
        IList<Customer> GetAllCustomer();
    }
}