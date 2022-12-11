using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SOC.DataContracts.Response;

namespace SOC.REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonBanController : ControllerBase
    {
        private readonly IPersonBanService personBanService;

        public PersonBanController(IPersonBanService personBanService)
        {
            this.personBanService = personBanService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonBanResponse>> GetPersonBanById(Guid id)
        {
            var personBan = await personBanService.GetById(id);
            if (personBan is null)
            {
                return NotFound();
            }
            return (PersonBanResponse)personBan;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonBanResponse>>> GetPersonBans()
        {
            var personBans = (await personBanService.GetAll()).Select(t => (PersonBanResponse)t);
            return new ActionResult<IEnumerable<PersonBanResponse>>(personBans);
        }

        [HttpPost]
        public async Task<ActionResult<PersonBanResponse>> AddPersonBan([FromBody] AddPersonBanRequest personBan)
        {
            return (PersonBanResponse)await personBanService.Add((PersonBan)personBan);
        }

        [HttpPatch]
        public async Task<ActionResult<PersonBanResponse>> UpdatePersonBan([FromBody] UpdatePersonBanRequest personBan)
        {
            var updatedPersonBan = await personBanService.Update(personBan);
            return updatedPersonBan is null ? NotFound() : (PersonBanResponse)updatedPersonBan;
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePersonBan(Guid id)
        {
            await personBanService.Delete(id);
            return NoContent();
        }
    }
}