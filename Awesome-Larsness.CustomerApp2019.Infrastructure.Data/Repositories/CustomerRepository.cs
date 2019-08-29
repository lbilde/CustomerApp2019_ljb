using System.Collections.Generic;
using System.Linq;
using Awesome_Larsness.CustomerApp2019.Core.DomainService;
using Awesome_Larsness.CustomerApp2019.Core.Entity;

namespace Awesome_Larsness.CustomerApp2019.Infrastructure.Data.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        public List<Customer> ReadAll()
        {
            return FakeDB.CustomerTable;
        }

        public Customer Create(Customer customer)
        {
            customer.Id = FakeDB.CustomerId++;
            FakeDB.CustomerTable.Add(customer);
            return customer;
        }

        public Customer Delete(int id)
        {
            var toRemove = FakeDB.CustomerTable.FirstOrDefault(cust => cust.Id == id);
            FakeDB.CustomerTable.Remove(toRemove);
            return toRemove;
        }
    }
}