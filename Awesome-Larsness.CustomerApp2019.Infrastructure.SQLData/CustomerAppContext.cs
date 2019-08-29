using Awesome_Larsness.CustomerApp2019.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace CustomerApp.Infrastructure.SQLData
{
    public class CustomerAppContext: DbContext
    {
        public CustomerAppContext(DbContextOptions<CustomerAppContext> opt) 
            : base(opt) { }

        public DbSet<Customer> Customers { get; set; }
      
    }
}