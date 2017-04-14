using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using genebygene2017.Data;
using genebygene2017.Models;
using Microsoft.AspNetCore.Cors;

namespace genebygene2017.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    public class UsersController : Controller
    {
        public GGContext dbContext = null;
        public UsersController(GGContext context)
        {
            dbContext = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Users> Get()
        {
            return dbContext.Users.ToList();
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
