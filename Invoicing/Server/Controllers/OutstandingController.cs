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
    public class OutstandingController : ControllerBase
    {
        private readonly ILogger<OutstandingController> _logger;
        private readonly IBusinessData _data;

        public OutstandingController(ILogger<OutstandingController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public decimal Get()
        {
            return _data.Outstanding;
        }
    }
}
