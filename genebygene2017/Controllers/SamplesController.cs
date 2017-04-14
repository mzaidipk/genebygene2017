using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using genebygene2017.Data;
using genebygene2017.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Cors;

namespace genebygene2017.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    public class SamplesController : Controller
    {

        public GGContext dbContext = null;
        public SamplesController(GGContext context)
        {
            dbContext = context;
        }

        [HttpGet("GetAllSamplesWithName")]
        public IEnumerable<dynamic> GetAllSamplesWithName()
        {
            var st = dbContext.Statuses;
            var sam = dbContext.Samples;
            //var query = from s in st
            //            join sm in sam on s.StatusId equals sm.StatusId
            //            select new { sm.SampleId, sm.Barcode, sm.CreatedAt, sm.CreatedBy, s.Status };
            var query = from sm in sam
                        select new { sm.SampleId, sm.Barcode, sm.CreatedAt, sm.Status.Status, sm.CreatedByNavigation.FirstName, sm.CreatedByNavigation.LastName, CreatedByUser = sm.CreatedByNavigation.LastName + ", " + sm.CreatedByNavigation.FirstName, sm.CreatedBy, sm.StatusId };
            return query.ToList();
        }

        [HttpGet("Status/{id}")]
        public IEnumerable<dynamic> GetAllSamplesWithStatus(int id)
        {
            var sam = dbContext.Samples;
            var query = from sm in sam
                        where sm.StatusId == id
                        select new { sm.SampleId, sm.Barcode, sm.CreatedAt, sm.Status.Status, sm.CreatedByNavigation.FirstName, sm.CreatedByNavigation.LastName, CreatedByUser = sm.CreatedByNavigation.LastName + ", " + sm.CreatedByNavigation.FirstName, sm.CreatedBy, sm.StatusId };
            return query.ToList();
        }

        [HttpGet("User/{name}")]
        public IEnumerable<dynamic> GetAllSamplesWithName(string name)
        {
            var sam = dbContext.Samples;
            var query = from sm in sam
                        where sm.CreatedByNavigation.FirstName.Contains(name) || sm.CreatedByNavigation.LastName.Contains(name)
                        select new { sm.SampleId, sm.Barcode, sm.CreatedAt, sm.Status.Status, sm.CreatedByNavigation.FirstName, sm.CreatedByNavigation.LastName, CreatedByUser = sm.CreatedByNavigation.LastName + ", " + sm.CreatedByNavigation.FirstName, sm.CreatedBy, sm.StatusId };
            return query.ToList();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Samples> Get()
        {
            return dbContext.Samples.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Samples value)
        {
            try
            {
                value.SampleId = 0;
                var user = dbContext.Users.Find(value.CreatedBy);
                value.CreatedByNavigation = user;
                var status = dbContext.Statuses.Find(value.StatusId);
                value.Status = status;
                dbContext.Samples.Add(value);
                dbContext.SaveChanges();
                return Ok("Saved Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to Save Exception Reason:" + ex.Message);
            }
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
