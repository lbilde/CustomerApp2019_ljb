using System.Collections.Generic;
using Awesome_Larsness.CustomerApp2019.Core.Entity;

namespace Awesome_Larsness.CustomerApp2019.Core.DomainService
{
    public interface ICustomerRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // I Wanna be Able to Read All Customers
        List<Customer> ReadAll();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        // I Wanna be Able to Create a new Customer
        Customer Create(Customer customer);

        Customer Delete(int id);

    }
}