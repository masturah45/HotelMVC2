using System.Collections.Generic;
using System.Linq;
using Hotel_MVC2.ApplicationContext;
using Hotel_MVC2.Models;

namespace Hotel_MVC2.Repositories.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ContextClass _context;

        public CustomerRepository (ContextClass context)
        {
            _context = context;
        }

        public Customer CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public void DeleteCustomerUsingId(Customer customerNumber)
        {
            _context.Customers.Remove(customerNumber);
            _context.SaveChanges();
        }

        public IList<Customer> GetAllCustomer()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerId(string customerNumber)
        {
            var customer = _context.Customers.SingleOrDefault(a => a.CustomerNumber == customerNumber);
            return customer;
        }

        public Customer Login(string email, string password)
        {
            return _context.Customers.SingleOrDefault(a => a.Email == email && a.PassWord == password);
        }

        public Customer UpdateCustmer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return customer;
        }
    }
}