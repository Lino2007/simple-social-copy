using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SOC.REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Post?>> GetPostById(Guid id)
        {
            return await postService.GetById(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            return new ActionResult<IEnumerable<Post>>(await postService.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult<Post>> AddPost([FromBody] AddPostRequest Post)
        {
            return await postService.Add((Post)Post);
        }

        [HttpPatch]
        public async Task<ActionResult<Post?>> UpdatePost([FromBody] UpdatePostRequest Post)
        {
            return await postService.Update(Post);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            await postService.Delete(id);
            return NoContent();
        }
    }
}