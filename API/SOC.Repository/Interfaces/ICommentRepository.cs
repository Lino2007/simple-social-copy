using System.Threading.Tasks;
using SOC.DataContracts.Models;
using SOC.DataContracts.Request;

namespace SOC.Repository.Interfaces
{
    public interface ICommentRepository : ICrudRepository<Comment>
    {
        public Task<Comment?> UpdateComment(UpdateCommentRequest post);
    }
}