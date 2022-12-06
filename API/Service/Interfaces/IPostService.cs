using System.Threading.Tasks;
using API.Models;
using API.Models.Request;

namespace API.Service.Interfaces
{
    public interface IPostService : ICrudService<Post>
    {
        public Task<Post?> Update(UpdatePostRequest entity);
    }
}