using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invoicing.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Invoicing.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ILogger<DashboardController> _logger;
        private readonly IBusinessData _data;

        public DashboardController(ILogger<DashboardController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public string Get()
        {
            return "Revenu des ventes : "+_data.SalesRevenue+ " et revenu outstanding : "+ _data.Outstanding;
        }
    }
}
