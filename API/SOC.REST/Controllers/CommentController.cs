using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SOC.REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Comment?>> GetCommentById(Guid id)
        {
            return await commentService.GetById(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comment>>> GetComments()
        {
            return new ActionResult<IEnumerable<Comment>>(await commentService.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult<Comment>> AddComment([FromBody] AddCommentRequest comment)
        {
            return await commentService.Add((Comment)comment);
        }

        [HttpPatch]
        public async Task<ActionResult<Comment?>> UpdateComment([FromBody] UpdateCommentRequest comment)
        {
            return await commentService.Update(comment);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteComment(Guid id)
        {
            await commentService.Delete(id);
            return NoContent();
        }
    }
}