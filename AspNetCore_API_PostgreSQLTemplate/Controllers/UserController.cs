using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore_API_PostgreSQLTemplate.Repository;
using AspNetCore_API_PostgreSQLTemplate.Models;

namespace AspNetCore_API_PostgreSQLTemplate.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        private readonly IExampleUserRepository _repository;

        public UserController(IExampleUserRepository  repository)
        {
            _repository = repository;
        }
        
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            var user = _repository.GetPerson(id);
            return user;
        }

        // POST api/values
        [HttpPost]
        public Person Post([FromBody]Person person)
        {
            person.Document = new Document()
            {
                StartDate = new DateTime(),
                DocumentName = "Date someone"
            };
            _repository.AddPerson(person);
            return person;
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
