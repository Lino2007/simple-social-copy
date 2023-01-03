using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SOC.DataContracts.Response;

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
        public async Task<ActionResult<PostResponse>> GetPostById(Guid id)
        {
            var post = await postService.GetById(id);
            return post is null ? NotFound() : (PostResponse)post;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostResponse>>> GetPosts()
        {
            var posts = await postService.GetAll();
            return new ActionResult<IEnumerable<PostResponse>>(posts.Select(t => (PostResponse)t));
        }

        [HttpPost]
        public async Task<ActionResult<PostResponse>> AddPost([FromBody] AddPostRequest Post)
        {
            return (PostResponse)await postService.Add((Post)Post);
        }

        [HttpPatch]
        public async Task<ActionResult<PostResponse>> UpdatePost([FromBody] UpdatePostRequest post)
        {
            var updatedPost = await postService.Update(post);
            return updatedPost is null ? NotFound() : (PostResponse)updatedPost;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            await postService.Delete(id);
            return NoContent();
        }
    }
}