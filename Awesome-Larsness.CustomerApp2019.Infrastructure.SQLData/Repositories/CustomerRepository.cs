using System;
using System.Collections.Generic;
using System.Linq;
using Awesome_Larsness.CustomerApp2019.Core.DomainService;
using Awesome_Larsness.CustomerApp2019.Core.Entity;

namespace CustomerApp.Infrastructure.SQLData.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        readonly CustomerAppContext _ctx;

        public CustomerRepository(CustomerAppContext ctx)
        {
            _ctx = ctx;
        }
        public List<Customer> ReadAll()
        {
            return _ctx.Customers.ToList();
        }
        public Customer Create(Customer customer)
        {
            Console.WriteLine("Add Cusotmer");
            return null;
        }
        public Customer Delete(int id)
        {
            Console.WriteLine("Delete Cusotmer");
            return null;
        }
    }
}