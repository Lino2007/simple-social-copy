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
    }
}