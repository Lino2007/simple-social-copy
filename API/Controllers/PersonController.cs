using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Models.Request;
using API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
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
        public async Task<ActionResult<Person?>> GetPersonById(Guid id)
        {
            return await personService.GetById(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPeople()
        {
            return new ActionResult<IEnumerable<Person>>(await personService.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult<Person>> AddPerson([FromBody] AddPersonRequest person)
        {
            return await personService.Add((Person)person);
        }

        [HttpPatch]
        public async Task<ActionResult<Person?>> UpdatePerson([FromBody] UpdatePersonRequest person)
        {
            return await personService.Update(person);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePerson(Guid id)
        {
            await personService.Delete(id);
            return NoContent();
        }
    }
}