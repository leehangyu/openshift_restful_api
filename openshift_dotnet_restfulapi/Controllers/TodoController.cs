using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace kgy_Webapi.Controllers
{
    [Produces("application/json")]
    [Route("api/Todo")]
    public class TodoController : Controller
    {
        // GET: api/Todo
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Todo/5
        [HttpGet("{data}")]
        public string Get(int data)
        {
            return "value";
        }
        
        // POST: api/Todo
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Todo/5
        [HttpPut("{data}")]
        public void Put(int data, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{data}")]
        public void Delete(int data)
        {
        }
    }
}
