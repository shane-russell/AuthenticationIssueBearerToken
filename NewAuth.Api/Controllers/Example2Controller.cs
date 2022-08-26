using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewAuth.Api.Domain;
using NewAuth.Api.Repository;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewAuth.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Example2Controller : ControllerBase
    {

        private readonly INewAuthRepository _newAuthRepository;

        public Example2Controller(INewAuthRepository newAuthRepository)
        {
            _newAuthRepository = newAuthRepository;
        }

        // GET: api/<Example2Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Example2Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Example2Controller>
        [HttpPost]
        //[Authorize]
        public string Post([FromBody] string value)
        {
            return "hello from Post([FromBody] string value)";
        }

        // PUT api/<Example2Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Example2Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPost("addExample")]
        [Authorize] // only authenticated users can execute this action method.
        public IActionResult AddExampleDomainClass([FromBody] ExampleDomainClass exampleDomainClass)
        {
            _newAuthRepository.AddExampleDomainClass(exampleDomainClass);
            return Ok();
        }
    }
}
