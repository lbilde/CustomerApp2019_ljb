using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Awesome_Larsness.CustomerApp2019.Core.DomainService;
using Awesome_Larsness.CustomerApp2019.Core.Entity;

namespace Awesome_Larsness.CustomerApp2019.Core.ApplicationService.Services
{
    public class CustomerService: ICustomerService
    {
        private ICustomerRepository _customerRepo;

        public CustomerService(ICustomerRepository customerRepo)
        {
            this._customerRepo = customerRepo;
        }

        public List<Customer> FindAll()
        {
            return this._customerRepo.ReadAll();
        }

        public Customer FindSingle(int id)
        {
            return this._customerRepo.ReadAll()
                .FirstOrDefault(cust => cust.Id == id);
        }

        public Customer Add(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.FirstName))
            {
                throw new InvalidDataException(
                    "To create Customer needs a FirstName");
            }
            return this._customerRepo.Create(customer);
        }

        public Customer Delete(Customer customer)
        {
            return this._customerRepo.Delete(customer.Id);
        }
    }
}