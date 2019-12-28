using ProcessChanger.Entities;
using System.Collections.Generic;

namespace ProcessChanger.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetEntity(long id);
        IList<Customer> GetCustomers();
    }
}
