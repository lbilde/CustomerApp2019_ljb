using System;
using Awesome_Larsness.CustomerApp2019.Core.ApplicationService;
using Awesome_Larsness.CustomerApp2019.Core.ApplicationService.Services;
using Awesome_Larsness.CustomerApp2019.Core.DomainService;
using Awesome_Larsness.CustomerApp2019.Core.Entity;
using Awesome_Larsness.CustomerApp2019.Infrastructure.Data.Repositories;
using CustomerApp.Infrastructure.SQLData;
using Microsoft.EntityFrameworkCore;

namespace Awesome_Larsness.CustomerApp2019.Console2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                FirstName = "John",
                LastName = "Johnoson"
            };
            
            Customer customer2 = new Customer
            {
                FirstName = "Bill",
                LastName = "Billoson"
            };
            
            ICustomerRepository custRepoList = new CustomerRepository();
            ICustomerService custService = new CustomerService(GetSQLLiteRepo());

            custService.Add(customer1);
            custService.Add(customer2);

            var customers = custService.FindAll();
            foreach (var customer in customers)
            {
                Console.WriteLine($"FirstName: {customer.FirstName} LastName: {customer.LastName}");
            }

            custService.Delete(customer1);
            
            Console.WriteLine("Deleted 1 customer.......");
            var customers2 = custService.FindAll();
            foreach (var customer in customers2)
            {
                Console.WriteLine($"FirstName: {customer.FirstName} LastName: {customer.LastName}");
            }
            
            Console.ReadLine();
        }

        private static ICustomerRepository GetSQLLiteRepo()
        {
            var options = new DbContextOptionsBuilder<CustomerAppContext>();
            options.UseSqlite("Data Source=customerApp.db");
            var context = new CustomerAppContext(options.Options);
            DBInitializer.SeedDB(context);
            ICustomerRepository custRepoSQLLite = new CustomerApp.Infrastructure.SQLData.Repositories.CustomerRepository(context);
            return custRepoSQLLite;
        }
    }
}