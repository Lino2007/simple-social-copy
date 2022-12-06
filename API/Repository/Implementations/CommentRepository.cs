using System.Threading.Tasks;
using API.Models;
using API.Models.Request;
using API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repository.Implementations
{
    public class CommentRepository : CrudRepository<Comment>, ICommentRepository
    {
        public CommentRepository(SimpleSocialContext db) : base(db)
        {
        }

        public async Task<Comment?> UpdateComment(UpdateCommentRequest comment)
        {
            var c = await db.Comments.SingleOrDefaultAsync(c => c.Id.Equals(comment.Id));
            if (c == null)
            {
                return null;
            }
            db.Entry(c).CurrentValues.SetValues(comment);
            return await Update(c);
        }
    }
}