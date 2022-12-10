using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SOC.Repository.Implementations
{
    public class CommentRepository : CrudRepository<Comment>, ICommentRepository
    {
        public CommentRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}