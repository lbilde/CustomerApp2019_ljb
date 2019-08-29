using System;
using System.IO;
using Awesome_Larsness.CustomerApp2019.Core.ApplicationService;
using Awesome_Larsness.CustomerApp2019.Core.ApplicationService.Services;
using Awesome_Larsness.CustomerApp2019.Core.DomainService;
using Awesome_Larsness.CustomerApp2019.Core.Entity;
using Moq;
using Xunit;

namespace TestCore.ApplicationService.Service
{
    public class CustomerServiceTest
    {
        public CustomerServiceTest()
        {
            //Add reusable stuff
        }

        public void Dispose()
        {
            //Dispose Stuff we dont need anymore
        }
        
        [Fact]
        public void CreateCustomerWithMissingFirstNameThrowsException()
        {
            var custRepo = new Mock<ICustomerRepository>();
            ICustomerService service = new CustomerService(custRepo.Object);
            var customer = new Customer();
            Exception ex = Assert.Throws<InvalidDataException>(() => 
                service.Add(customer));
            Assert.Equal("To create Customer needs a FirstName", ex.Message);  
        }
        
        [Fact]
        public void CreateCustomerShouldCallCustomerRepoAddOnce()
        {
            var custRepo = new Mock<ICustomerRepository>();
            ICustomerService service = new CustomerService(custRepo.Object);
            var customer = new Customer {FirstName = "Bill"};
            service.Add(customer);
            custRepo.Verify(x => x.Create(It.IsAny<Customer>()), Times.Once);

        }

    }
}