using System.Threading.Tasks;
using API.Models;
using API.Models.Request;
using API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repository.Implementations
{
    public class PostRepository : CrudRepository<Post>, IPostRepository
    {
        public PostRepository(SimpleSocialContext db) : base(db)
        {
        }

        public async Task<Post?> UpdatePost(UpdatePostRequest post)
        {
            var p = await db.Posts.SingleOrDefaultAsync(p => p.Id.Equals(post.Id));
            if (p == null)
            {
                return null;
            }
            db.Entry(p).CurrentValues.SetValues(post);
            return await Update(p);
        }
    }
}