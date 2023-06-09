using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SOC.DataContracts.Response;

namespace SOC.REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService personService;

        public PersonController(IPersonService PersonService)
        {
            this.personService = PersonService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonResponse>> GetPersonById(Guid id)
        {
            var person = await personService.GetById(id);
            return (PersonResponse)person;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonResponse>>> GetPeople()
        {
            var people = (await personService.GetAll()).Select(t => (PersonResponse)t);
            return new ActionResult<IEnumerable<PersonResponse>>(people);
        }

        [HttpPost]
        public async Task<ActionResult<PersonResponse>> AddPerson([FromBody] AddPersonRequest person)
        {
            return (PersonResponse)await personService.Add((Person)person);
        }

        [HttpPost("register")]
        public async Task<ActionResult<PersonResponse>> RegisterPerson([FromBody] AddPersonRequest person)
        {
            var p = await personService.RegisterPerson((Person)person);
            return (PersonResponse)p;
        }

        [HttpPatch]
        public async Task<ActionResult<PersonResponse>> UpdatePerson([FromBody] UpdatePersonRequest person)
        {
            var updatedPerson = await personService.Update(person);
            return (PersonResponse)updatedPerson;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(Guid id)
        {
            await personService.Delete(id);
            return NoContent();
        }
    }
}