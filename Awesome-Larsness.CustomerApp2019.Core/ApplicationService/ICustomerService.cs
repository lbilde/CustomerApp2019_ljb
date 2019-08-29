using System.Collections.Generic;
using Awesome_Larsness.CustomerApp2019.Core.Entity;

namespace Awesome_Larsness.CustomerApp2019.Core.ApplicationService
{
    public interface ICustomerService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Customer> FindAll();
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Customer FindSingle(int Id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        Customer Add(Customer customer);

        Customer Delete(Customer customer);
    }
}