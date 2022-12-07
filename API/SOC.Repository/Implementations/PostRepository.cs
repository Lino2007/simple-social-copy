using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SOC.Repository.Implementations
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