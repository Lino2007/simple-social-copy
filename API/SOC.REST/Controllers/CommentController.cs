using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SOC.DataContracts.Response;

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
        public async Task<ActionResult<CommentResponse>> GetCommentById(Guid id)
        {
            var comment = await commentService.GetById(id);
            return comment is null ? NotFound() : (CommentResponse)comment;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommentResponse>>> GetComments()
        {
            var comments = (await commentService.GetAll()).Select(t => (CommentResponse)t);
            return new ActionResult<IEnumerable<CommentResponse>>(comments);
        }

        [HttpPost]
        public async Task<ActionResult<CommentResponse>> AddComment([FromBody] AddCommentRequest comment)
        {
            return (CommentResponse)await commentService.Add((Comment)comment);
        }

        [HttpPatch]
        public async Task<ActionResult<CommentResponse>> UpdateComment([FromBody] UpdateCommentRequest comment)
        {
            var updatedComment = await commentService.Update(comment);
            return updatedComment is null ? NotFound() : (CommentResponse)updatedComment;
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteComment(Guid id)
        {
            await commentService.Delete(id);
            return NoContent();
        }
    }
}