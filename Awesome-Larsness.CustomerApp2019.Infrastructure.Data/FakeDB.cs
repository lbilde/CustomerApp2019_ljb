using System.Collections.Generic;
using Awesome_Larsness.CustomerApp2019.Core.Entity;

namespace Awesome_Larsness.CustomerApp2019.Infrastructure.Data
{
    public class FakeDB
    {
        internal static int CustomerId = 1;
        internal static List<Customer> CustomerTable = new List<Customer>();

        public static void  SeedDB()
        {
            CustomerTable.Add(
                new Customer
                {
                    FirstName = "Ingo",
                    LastName = "Nøffe"
                });
            CustomerTable.Add(
                new Customer
                {
                    FirstName = "Bingo",
                    LastName = "Børgesen"
                });
        }
    }
}