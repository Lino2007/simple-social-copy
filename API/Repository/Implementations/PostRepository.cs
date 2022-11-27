using API.Models;
using API.Repository.Interfaces;

namespace API.Repository.Implementations
{
    public class PostRepository : CrudRepository<Post>, IPostRepository
    {
        public PostRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}