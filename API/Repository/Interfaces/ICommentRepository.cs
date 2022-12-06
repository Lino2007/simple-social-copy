using System.Threading.Tasks;
using API.Models;
using API.Models.Request;

namespace API.Repository.Interfaces
{
    public interface ICommentRepository : ICrudRepository<Comment>
    {
        public Task<Comment?> UpdateComment(UpdateCommentRequest post);
    }
}