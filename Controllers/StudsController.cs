using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAPI.Context;
using DemoAPI.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudsController : ControllerBase
    {
        // GET: api/<StudsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            using (var context = new AppDBContext())
            {
                return context.Students.ToList();
            }
        }

        // GET api/<StudsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
