using Awesome_Larsness.CustomerApp2019.Core.Entity;

namespace CustomerApp.Infrastructure.SQLData
{
    public class DBInitializer
    {
        public static void SeedDB(CustomerAppContext ctx)
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
            ctx.Customers.Add(new Customer()
            {
                FirstName = "John",
                LastName = "Olesen"
            });
                    
            ctx.Customers.Add(new Customer()
            {
                FirstName = "Bill",
                LastName = "Bøllesen"
            });
               
            ctx.SaveChanges();
        }
    }
}