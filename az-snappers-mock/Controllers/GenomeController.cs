using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace az_snappers_mock.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GenomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Genome test service";
        }
    }
}
