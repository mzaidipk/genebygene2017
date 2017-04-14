using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using genebygene2017.Data;
using genebygene2017.Models;

namespace genebygene2017.Controllers
{
    [Route("api/[controller]")]
    public class StatusesController : Controller
    {
        public GGContext dbContext = null;
        public StatusesController(GGContext context)
        {
            dbContext = context;
        }

        

        // GET api/values
        [HttpGet]
        public IEnumerable<Statuses> Get()
        {
            return dbContext.Statuses.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
