using API.Models;
using API.Repository.Interfaces;

namespace API.Repository.Implementations
{
    public class CommentRepository : CrudRepository<Comment>, ICommentRepository
    {
        public CommentRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}