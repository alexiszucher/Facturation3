using Invoicing.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoicing.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly ICustomer _data;

        public CustomersController(ILogger<CustomersController> logger, ICustomer data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _data.AllCustomers;
        }
    }
}
