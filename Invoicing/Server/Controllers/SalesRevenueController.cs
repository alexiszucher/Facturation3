using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invoicing.Server.Models;
using Invoicing.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Invoicing.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesRevenueController : ControllerBase
    {
        private readonly ILogger<SalesRevenueController> _logger;
        private readonly IBusinessData _data;

        public SalesRevenueController(ILogger<SalesRevenueController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public decimal Get()
        {
            return _data.SalesRevenue;
        }
    }
}
