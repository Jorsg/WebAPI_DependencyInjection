using DependencyInjection.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_DependencyInjection.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase {

        private readonly IPersonService _personService;

        public PersonController(IPersonService personService) {
            _personService = personService ?? throw new ArgumentNullException(nameof(personService));
        }

        [HttpGet]
        public async Task<IActionResult> GetPerson() 
        {
            var result = await _personService.GetPerson();
            return Ok(result);
        }
    }
}
