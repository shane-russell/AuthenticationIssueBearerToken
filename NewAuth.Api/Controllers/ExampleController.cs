using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewAuth.Api.Domain;
using NewAuth.Api.Repository;

namespace NewAuth.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly INewAuthRepository _newAuthRepository;

        public ExampleController(INewAuthRepository newAuthRepository)
        {
            _newAuthRepository = newAuthRepository;
        }

        [HttpPost("addExample")]
        [Authorize] // only authenticated users can execute this action method.
        public IActionResult AddExampleDomainClass(ExampleDomainClass exampleDomainClass)
        {
            _newAuthRepository.AddExampleDomainClass(exampleDomainClass);
            return Ok();
        }
    }
}
