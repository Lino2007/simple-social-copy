using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<PersonBan?>> GetPersonBanById(Guid id)
        {
            return await personBanService.GetById(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonBan>>> GetPersonBans()
        {
            return new ActionResult<IEnumerable<PersonBan>>(await personBanService.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult<PersonBan>> AddPersonBan([FromBody] AddPersonBanRequest personBan)
        {
            return await personBanService.Add((PersonBan)personBan);
        }

        [HttpPatch]
        public async Task<ActionResult<PersonBan?>> UpdatePersonBan([FromBody] UpdatePersonBanRequest personBan)
        {
            return await personBanService.Update(personBan);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePersonBan(Guid id)
        {
            await personBanService.Delete(id);
            return NoContent();
        }
    }
}