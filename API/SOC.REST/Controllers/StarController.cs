using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SOC.DataContracts.Response;

namespace SOC.REST.Controllers
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
        public async Task<ActionResult<StarResponse>> GetStarById(Guid id)
        {
            var star = await starService.GetById(id);
            return star is null ? NotFound() : (StarResponse)star;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StarResponse>>> GetStars()
        {
            var stars = (await starService.GetAll()).Select(t => (StarResponse)t);
            return new ActionResult<IEnumerable<StarResponse>>(stars);
        }

        [HttpPost("comment")]
        public async Task<ActionResult<StarResponse>> AddStarToComment([FromBody] AddCommentStarRequest star)
        {
            return (StarResponse)await starService.Add((Star)star);
        }

        [HttpPost("post")]
        public async Task<ActionResult<StarResponse>> AddStarToPost([FromBody] AddPostStarRequest star)
        {
            return (StarResponse)await starService.Add((Star)star);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStar(Guid id)
        {
            await starService.Delete(id);
            return NoContent();
        }
    }
}