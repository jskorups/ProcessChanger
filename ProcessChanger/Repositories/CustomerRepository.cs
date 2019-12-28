using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProcessChanger.Entities;

namespace ProcessChanger.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private IList<Customer> _customers = new List<Customer>()
        {

            new Customer
            {
                Id = 1,
                Name = "Ford"
            }
        };

        public IList<Customer> GetCustomers()
        {
            return _customers;
        }

        public Customer GetEntity(long id)
        {
            return _customers.SingleOrDefault(c => c.Id == id);
        }
    }
}