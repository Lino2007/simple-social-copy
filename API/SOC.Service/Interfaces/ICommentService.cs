using SOC.DataContracts.Models;
using SOC.DataContracts.Request;

namespace SOC.Service.Interfaces
{
    public interface ICommentService : ICrudService<Comment>
    {
        Task<Comment?> Update(UpdateCommentRequest entity);
    }
}