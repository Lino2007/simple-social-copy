using System.Threading.Tasks;
using API.Models;
using API.Models.Request;

namespace API.Service.Interfaces
{
    public interface ICommentService : ICrudService<Comment>
    {
        public Task<Comment?> Update(UpdateCommentRequest entity);
    }
}