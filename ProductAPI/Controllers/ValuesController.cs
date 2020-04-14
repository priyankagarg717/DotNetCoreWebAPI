using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesCOntroller: Controller
    {
        //GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"value1","value2"};
        }

         //GET api/values/5
        [HttpGet("{id}")]
        public IEnumerable<string> Get(int id)
        {
            return new string[] {"value"};
        }

        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {}
    }
}