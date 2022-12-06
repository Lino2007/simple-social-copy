using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;
using API.Models.Request;
using API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StarController : ControllerBase
    {
        private readonly IStarService starService;

        public StarController(IStarService starService)
        {
            this.starService = starService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Star?>> GetStarById(Guid id)
        {
            return await starService.GetById(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Star>>> GetStars()
        {
            return new ActionResult<IEnumerable<Star>>(await starService.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult<Star>> AddStar([FromBody] AddStarRequest star)
        {
            return await starService.Add((Star)star);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStar(Guid id)
        {
            await starService.Delete(id);
            return NoContent();
        }
    }
}