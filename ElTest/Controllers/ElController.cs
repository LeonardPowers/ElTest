using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElTest.Model;

namespace ElTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElController : ControllerBase
    {

        public ElController(ILogger<ElController> logger)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("Rule")]
        public async Task<ActionResult> AddRule(ElDefaultRuleDto request)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("Request")]
        public async Task<ActionResult> AddRequest(ElRequestDto request)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("Client")]
        public async Task<ActionResult> AddClient(ElClientDto request)
        {
            throw new NotImplementedException();
        }
    }
}
