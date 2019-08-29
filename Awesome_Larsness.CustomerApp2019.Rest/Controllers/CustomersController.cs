using System;
using Awesome_Larsness.CustomerApp2019.Core.ApplicationService;
using Awesome_Larsness.CustomerApp2019.Core.Entity;
using Microsoft.AspNetCore.Mvc;

namespace EASV.CustomerRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET api/customers -- READ All
        [HttpGet]
        public ActionResult<Customer> Get()
        {
            try
            {
                return Ok(_customerService.FindAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
    }
}
