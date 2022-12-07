using SOC.DataContracts.Models;
using SOC.DataContracts.Request;

namespace SOC.Service.Interfaces
{
    public interface IPostService : ICrudService<Post>
    {
        public Task<Post?> Update(UpdatePostRequest entity);
    }
}